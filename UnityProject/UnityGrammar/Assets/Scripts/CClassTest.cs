using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
/*
public class 클래스명
{
    // [접근지정자]
    // public, private, protected(?)
    // public : 외부 클래스 메소드에서 속성의 접근이 가능
    // private : 외부 클래스 메소드에서 속성의 접근이 불가능
  
    // [속성 선언]
    // 접근지정자 타입 변수들...
}
*/
  
// x,y,x값을 가진 위치 타입 (클래스)
public class CVector
{
    public float posx;
    public float posy;
    public float posz;
  
    public CVector(float x, float y, float z)
    {
        Init(x, y, z);
    }
  
    public void Init(float posx, float posy, float posz)
    {
        SetPositionX(posx);
        SetPositionY(posy);
        SetPositionZ(posz);
    }
  
    public void SetPositionX(float posx)
    {
        this.posx = posx;
  
        if (this.posx < 0) this.posx = 0;
    }
  
    public void SetPositionY(float posy)
    {
        this.posy = posy;
  
        if (this.posy < 0) this.posy = 0;
    }
  
    public void SetPositionZ(float posz)
    {
        this.posz = posz;
  
        if (this.posz < 0) this.posz = 0;
    }
}
  
// 위치x와 체력을 가진 몬스터 타입 (클래스)
public class CMonster
{
    // 멤버 변수 (프로퍼티)
    /*
    private float posx; // x위치
    private float posy; // y위치
    private float posz; // z위치
    */
    private CVector position; // x, y, z위치
    private int hp; // 체력
  
    /*
    public void Init(int hp, float posx, float posy, float posz)
    {
        SetHp(hp);
        SetPositionX(posx);
        SetPositionY(posy);
        SetPositionZ(posz);
    }
    */
  
    // CMonster 생성자
    public CMonster(int hp, CVector position)
    {
        Init(hp, position);
    }
  
    public CMonster(int hp, float x, float y, float z)
    {
        //CVector position = new CVector();
        //position.Init(x, y, z);
  
        CVector position = new CVector(x, y, z);
        Init(hp, position);
    }
  
    private void Init(int hp, CVector position)
    {
        SetHp(hp);
        this.position = position;
    }
  
    // 멤버 함수 (메소드)
  
    private void SetHp(int hp)
    {
        this.hp = hp;
  
        if (this.hp < 0) this.hp = 0;
    }   
  
    // 몬스터 이동 메소드
    public void RightMove()
    {
        float x = position.posx;
        x += 2;
        position.SetPositionX(x);
    }
  
    public CVector GetPosition()
    {
        return position;
    }
  
    public void Hit()
    {
        if (hp <= 0)
        {
            hp = 0;
            return;
        }
  
        hp -= 10;
    }
  
    public int GetHp()
    {
        return hp;
    }
}
  
public class CClassTest : MonoBehaviour {
  
    // Use this for initialization
    void Start () {
  
        // 객체 생성
        // 클래스명 객체변수명 = new 클래스명();
        //CMonster monster = new CMonster();
  
        // 몬스터 객체의 초기화
        //monster.SetHp(100);
        //monster.SetPositionX(0);
  
        // 매번 두개의 Set함수를 호출한다면
        // 하나의 함수로 만들어주면 좋겠죠? ㅎ
        CVector position = new CVector(1, 2, 3);
        //position.SetPositionX(0);
        //position.SetPositionY(0);
        //position.SetPositionZ(0);
        //position.Init(0, 0, 0);
        //monster.Init(100, position);
        // 생성자를 통한 초기화를 수행하면서 객체를 생성함
        CMonster monster = new CMonster(100, position);
  
        //CMonster monster1 = new CMonster(100, 1, 2, 3);
  
        // 몬스터는 외쪽으로 이동하면 안되는데
        // public일 경우 외부에서 의도 하지 않게 문제를 만들 수 있음
        //monster.posx -= 20;
        //Debug.Log("monster xpos => " + monster.posx);
  
        // 객체의 멤버 변수(속성) 접근
        // 객체변수명.속성변수명 = 값;
        //monster.posx = 2;
  
        //MonsterRightMove(monster); // 오른쪽으로 몬스터 2 이동
        //MonsterRightMove(monster); // 오른쪽으로 몬스터 2 이동
        //MonsterRightMove(monster); // 오른쪽으로 몬스터 2 이동
  
        Debug.Log("monster xpos => " + monster.GetPosition().posx);
  
        // 객체의 멤버 메소드(함수) 호출(행위 요청)
        // 객체변수명.메소드명();
        monster.RightMove(); // 오른쪽으로 몬스터 2 이동
        monster.RightMove(); // 오른쪽으로 몬스터 2 이동
        monster.RightMove(); // 오른쪽으로 몬스터 2 이동
  
        Debug.Log("monster xpos => " + monster.GetPosition().posx);
  
        monster.Hit();
        monster.Hit();
        monster.Hit();
  
        Debug.Log("monster hp => " + monster.GetHp());
    }
  
    /*
    // 몬스터 이동 메소드
    void MonsterRightMove(CMonster monster)
    {
        monster.posx += 2;
    }
    */
}