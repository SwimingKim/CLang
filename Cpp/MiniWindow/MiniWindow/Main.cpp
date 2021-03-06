#include <Windows.h>
#include <d3d9.h>

#pragma comment (lib, "d3d9.lib")
#if defined (DEBUG) || defined (_DEBUG)
#pragma comment (lib,  "d3dx9d.lib")
#else
#pragma comment (lib, "d3d9.lib")
#endif

// 윈도우 크기 설정
#define SCREEN_WIDTH 800
#define SCREEN_HEIGHT 600

// global declarations
LPDIRECT3D9 d3d; // 다이렉트 3D
LPDIRECT3DDEVICE9 d3ddev; // 다이렉트 3D 렌더링에 사용될 디바이스
LPDIRECT3DVERTEXBUFFER9 v_buffer = NULL; // 정적 버퍼

void initD3D(HWND hWnd);
void renderFr();
void cleanD3D();

// 정적 버퍼 초기화
void initVB();

// 커스텀 정점 구조체 선언
struct CUSTOMVERTEX
{
	FLOAT X, Y, Z, RHW; // 정점 위치 정보
	DWORD COLOR; // 정점 색상
};

// 정점 포맷 (위치 | 색상)
#define CUSTOMFVF (D3DFVF_XYZRHW | D3DFVF_DIFFUSE)

// 윈도우 프로시저
// -> 어플리케이션에 전달된 메시지에 맞는 처리를 수행
LRESULT CALLBACK WindowProc(
	HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);

// 윈도우 메인 함수 정의
int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPreInstance, LPSTR lpCmdLine, int nCmdShow)
{
	// 윈도우 핸들 선언
	HWND hWnd;

	// 윈도우 클래스 정보
	WNDCLASSEX wc;

	// 윈도우 클래스 정보 초기화
	ZeroMemory(&wc, sizeof(WNDCLASSEX));

	// 윈도우 속성 정의
	wc.cbSize = sizeof(WNDCLASSEX);
	// 윈도우 스타일
	wc.style = CS_HREDRAW | CS_VREDRAW; // 사이즈 변경시 다시 그림
	// 메서지를 처리할 윈도우 프로시저를 참조
	wc.lpfnWndProc = WindowProc;
	// 윈도우 인스턴스 설정
	wc.hInstance = hInstance;
	// 마우스 커서 설정
	wc.hCursor = LoadCursor(NULL, IDC_ARROW);
	// 윈도우 색상 변경 (윈도우 색상)
	wc.hbrBackground = (HBRUSH)COLOR_WINDOW;
	// 윈도우 클래스 이름
	wc.lpszClassName = "Mini Window";

	RegisterClassEx(&wc); // 윈도우 클래스 정보 등록

	hWnd = CreateWindowEx(
		NULL,
		"Mini Window",
		"Mini WIndow Title", // 타이틀
		WS_OVERLAPPEDWINDOW, // 윈도우 스타일
		0, 0, // X, Y 위치
		SCREEN_WIDTH, SCREEN_HEIGHT, // 윈도우 가로, 세로 크기
		NULL, // 부모 윈도우
		NULL, // 메뉴
		hInstance,
		NULL
	);

	ShowWindow(hWnd, nCmdShow);

	initD3D(hWnd);

	MSG msg; // 이벤트 메세지

	/*
	// 메세지 큐에서 메세지를 뽑음
	while (GetMessage(&msg, NULL, 0, 0))
	{
		// 키보드 입력 메세지 처리
		TranslateMessage(&msg);

		// 메세지 프로시저에 메세지 전달
		DispatchMessage(&msg);
	}
	*/

	// 무한 루프 생성 (게임용)
	while (TRUE)
	{
		// 메세지 큐에서 메세지를 뽑음 (없으면 바로 리턴)
		while (PeekMessage(&msg, NULL, 0, 0, PM_REMOVE))
		{
			// 키보드 입력 메세지 처리
			TranslateMessage(&msg);
			
			// 메세지 프로시저에 메세지 전달
			DispatchMessage(&msg);
		}

		// 나가기 메시지라면
		if (msg.message == WM_QUIT)
			break;

		// 게임 코드 실행
		renderFr();
	}

	cleanD3D();

	return msg.wParam;

}

LRESULT CALLBACK WindowProc(
	HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	// 메세지를 처리함
	switch (message)
	{
		// 윈도우 파괴 메세지가 오면
	case WM_DESTROY:
	{
		// WM_QUIT 메세지를 메세지큐에 넣음
		PostQuitMessage(0);
		return 0;
	}
	break;
	}

	return DefWindowProc(hWnd, message, wParam, lParam);
}

void initD3D(HWND hWnd)
{
	// 다이렉트 3d 객체를 생성
	d3d = Direct3DCreate9(D3D_SDK_VERSION);

	// 다이렉트 3d 초기화 관련 정보 설정
	D3DPRESENT_PARAMETERS d3dpp;

	ZeroMemory(&d3dpp, sizeof(d3dpp));
	d3dpp.Windowed = TRUE; // 창 모드 여부
	d3dpp.SwapEffect = D3DSWAPEFFECT_DISCARD; // SWAP(플리핑) 방식
	d3dpp.hDeviceWindow = hWnd; // 윈도우 핸들
	d3dpp.BackBufferFormat = D3DFMT_X8R8G8B8; // 색상 팔레트
	d3dpp.BackBufferWidth = SCREEN_WIDTH; // 창 크기 (가로)
	d3dpp.BackBufferHeight = SCREEN_HEIGHT; // 창 크기 (세로)

											// 다이렉트3d 장치 생성
	d3d->CreateDevice(D3DADAPTER_DEFAULT, // 기본 (비디오카드)
		D3DDEVTYPE_HAL, // H/W 가속 장치 사용
		hWnd, // 윈도우 핸들
		D3DCREATE_SOFTWARE_VERTEXPROCESSING, // S/W, H/W 렌더링 선택
		&d3dpp, // 초기화 관련 정보
		&d3ddev); // 다이렉트 3d 장치

	// 정점 정보 초기화
	initVB();
}


// 프레임 랜더링
void renderFr()
{
	d3ddev->Clear(0, NULL, D3DCLEAR_TARGET, D3DCOLOR_XRGB(0, 0, 0), 1.0f, 0);

	d3ddev->BeginScene();

	// 정점 쉐이더 정보를 설정함
	d3ddev->SetFVF(CUSTOMFVF);

	// 정점 정보를 후면 버퍼에 바인딩함
	d3ddev->SetStreamSource(0, v_buffer, 0, sizeof(CUSTOMVERTEX));

	// 삼각형을 그림
	d3ddev->DrawPrimitive(D3DPT_TRIANGLELIST, 0, 1);

	d3ddev->EndScene();

	d3ddev->Present(NULL, NULL, NULL, NULL);
}


void cleanD3D()
{
	// 정점 정보를 파괴함
	v_buffer->Release();

	d3ddev->Release();
	d3d->Release();
}


// 정점 정보를 초기화함
void initVB()
{
	// 정점 정보 구조체를 생성함
	CUSTOMVERTEX vertices[] =
	{
		{ 400.0f, 62.5f, 0.5f, 1.0f, D3DCOLOR_XRGB(0, 0, 255), },
		{ 650.0f, 500.0f, 0.5f, 1.0f, D3DCOLOR_XRGB(0, 255, 0), },
		{ 150.0f, 500.0f, 0.5f, 1.0f, D3DCOLOR_XRGB(255, 0, 0), },
	};

	// 정점 버퍼를 생성함
	d3ddev->CreateVertexBuffer(3 * sizeof(CUSTOMVERTEX),
		0,
		CUSTOMFVF,
		D3DPOOL_MANAGED,
		&v_buffer,
		NULL);

	VOID* pVoid;

	// 정점 버퍼 잠금
	v_buffer->Lock(0, 0, (void**)&pVoid, 0);
	// 정점 정보를 기록함
	memcpy(pVoid, vertices, sizeof(vertices));
	// 정점 버퍼 잠금을 해제함
	v_buffer->Unlock();
}

