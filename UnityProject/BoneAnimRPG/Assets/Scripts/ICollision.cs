using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 인터페이스
// 상속 관계에 있지 않은 객체간의 다형적 관계를 만들때 사용하는 문법
public interface ICollision {

    void Hit(bool isWeapon); // 인터페이스 메소드

}
