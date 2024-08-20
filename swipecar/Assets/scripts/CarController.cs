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
    public System.Action moveAction; // �븮�� ��������

    // �̺�Ʈ�� ���� 
    void Start()
    {
        state = State.Stop;
    }

    void Update()
    {
        if (state == State.Move)
        {
            this.transform.Translate(moveSpeed, 0, 0);
            moveSpeed *= 0.96f; // �����ΰ���
                                // UpdateDistanceUi();
                                // Debug.Log(moveSpeed);
            moveAction(); // �븮�� ȣ��
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

    // ���� ���� �޼���� �Ʒ�
    public void Move(InputManager.Direction direction)
    {
        int dir = (int)direction;
        Debug.Log($"<color=yellow>Move: {direction}, {dir}</color>");
        float speed = 0.1f;
        this.moveSpeed = dir * speed; // �ӵ� ����
        Debug.Log($"<color=yellow>moveSpeed: {moveSpeed}</color>");
        this.state = State.Move;
        isStop = false;
    }
}
