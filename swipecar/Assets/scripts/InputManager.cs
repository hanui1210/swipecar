using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // ������������
    public enum Direction
    {
        Left=-1, Right =1
        //CarController���� moveSpeed + / - ������ �������Ŀ� ������ ����
        //if (direction == InputManager.Direction.Right)
        //{
        //    moveSpeed = 0.1f;
        //}
        //else if (direction == InputManager.Direction.Left)
        //{
        //    moveSpeed = -0.1f;
        //}
    }
    // �븮�� ���� ����
    public System.Action<Direction> swipeAction;

    private Vector3 startPos;

    // Update is called once per frame
    void Update()
    {
        bool isDown = Input.GetMouseButtonDown(0);
        if (isDown)
        {
            this.startPos=Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector3 endPos= Input.mousePosition;
            float dirx = endPos.x - startPos.x; // �Ÿ�

            if (dirx > 0)
            {
                // swipeAction �ּ� Ȯ�ο�
                // System.Action'1[InputManage+Diraction]
               // Debug.Log($"swipeAction: {swipeAction}");

                //�븮��ȣ��               
                this.swipeAction(Direction.Right);
            }
            else if (dirx < 0)
            {
                this.swipeAction(Direction.Left);
            }

            //������, ���� �̵��� enum���� ���� �� �븮�� �����ؼ� �����ϰ� ��� 
            /*
            if (dirX > 0)
            {
                Debug.Log($"���������� {Mathf.Abs(dirX)}m�̵��մϴ�");
                moveSpeed = 0.05f;
            }
            else if (dirX < 0)
            {
                Debug.Log($"�������� {Mathf.Abs(dirX)}m�̵��մϴ�");
                moveSpeed = -0.01f;
            }
            */

        }
    }
}
