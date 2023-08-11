using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // 키보드 입력을 받기 위해 Vector2 라는 자료형을 inputVec 이라는 변수로 지정.
    public Vector2 inputVec;
    Rigidbody2D rigid;
    public float speed;

    // Awake는 스크립트가 종료되기 까지 딱 한번만 실행
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트 가져오기
        speed = 3f;
    }

    // 한 프레임마다 진행되는 함수
    void Update()
    {
        // 수평 수직 입력을 받는 코드
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");

    }

    // 물리 연산 프레임마다 호출되는 함수
    void FixedUpdate()
    {
        //위치 이동
        Vector2 nextVec =  inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);

    }


}