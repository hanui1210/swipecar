using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour    
{
    public enum State
    {
        Move, Stop
    }
    public GameObject textGo;
    public float moveSpeed;
    private State state;
    private bool isStop;
    public System.Action moveAction; // 대리자 변수정의

    // 이벤트는 위에 
    void Start()
    {
        state = State.Stop;
    }

    void Update()
    {
        if (state == State.Move)
        {
            this.transform.Translate(moveSpeed, 0, 0);
            moveSpeed *= 0.96f; // 앞으로가기
                                // UpdateDistanceUi();
                                // Debug.Log(moveSpeed);
            moveAction(); // 대리자 호출
        }
        if (moveSpeed != 0 && Mathf.Abs(moveSpeed) <= 0.01f)
        {
            if (isStop != false)
            {
                state = State.Stop;
                Debug.Log(state);
                isStop = true;
            }
        }
        
    }

    // 내가 만든 메서드는 아래
    public void Move(InputManager.Direction direction)
    {
        int dir = (int)direction;
        Debug.Log($"<color=yellow>Move: {direction}, {dir}</color>");
        float speed = 0.1f;
        this.moveSpeed = dir * speed; // 속도 적용
        Debug.Log($"<color=yellow>moveSpeed: {moveSpeed}</color>");
        this.state = State.Move;
        isStop = false;
    }
}
