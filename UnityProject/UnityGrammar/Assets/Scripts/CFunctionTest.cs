using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 구조체 (커스텀 타입)
public struct Result
{
    public int sumResult;
    public int mulResult;
}

public class CFunctionTest : MonoBehaviour {
    // Use this for initialization
    void Start () {
        Sum(); // 1번 함수 호출

		// 2번 함수 호출
        int val1 = 10;
        int val2 = 20;
        Sum2(val1, val2); 

		// 3번 함수 호출
		int result = Sum3(val1, val2);

		// 4번 함수 호출
        int sumResult = 0; // ref는 함수를 호출하기 전에 초기화되어야 함
        int mulResult;
        // SumMulti(20, 30, out sumResult, out mulResult);
        SumMulti(20, 30, ref sumResult, out mulResult);
        int rresult = SumMulti(20, 30, ref sumResult, out mulResult);
        Debug.Log(sumResult + " : " + mulResult);

        Result mresult = SumMulti(10, 20);
        Debug.Log("Sum : " + mresult.sumResult + " Mul : " + mresult.mulResult);

    }

	// 1. 반복되는 코드의 실행 시 함수를 실행하는 쪽에서 가변적인 데이터 지정이 필요 없을 경우
	// [유형] 리턴값도 매개변수도 없는 함수
	void Sum()
	{	
		// 반복코드
		int val1 = 10;
		int val2 = 20;

        int result = val1 + val2;
        Debug.Log(val1 + " + " + val2 + " = " + result);
	}

	// 2. 반복되는 코드의 실행 시 함수를 실행하는 쪽에서 가변적인 데이터 지정이 필요할 경우
	// [유형] 리턴값은 없고 매개변수는 있는 함수
	void Sum2(int val1, int val2)
	{
        int result = val1 + val2;
        Debug.Log(val1 + " + " + val2 + " = " + result);
    }

	// 3. 반복되는 코드의 실행 시 함수를 실행하는 쪽에서 가변적인 데이터 지정이 필요하고 함수의 기능 처리 후 결과를 함수를 실행하는 쪽에서 필요할 경우
	// [유형] 리턴값이 있고 매개변수가 있는 함수
	int Sum3(int val1, int val2)
	{
        int result = val1 + val2;
        return result;
    }

	/*
	void SumMulti(int val1, int val2, out int sumResult, out int mulResult)
	{
        sumResult = val1 + val2;
        mulResult = val1 * val2;
    }
	 */


	Result SumMulti(int val1, int val2)
	{
        Result result;
        result.sumResult = val1 + val2;
        result.mulResult = val1 * val2; // out은 함수 안에서 반드시 할당되어야 함

        return result;
    }

	int SumMulti(int val1, int val2, ref int sumResult, out int mulResult)
	{
        sumResult = val1 + val2;
        mulResult = val1 * val2;

        return mulResult;
    }




}
