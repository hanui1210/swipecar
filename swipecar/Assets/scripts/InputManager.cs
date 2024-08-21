using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // 열거형식정의
    public enum Direction
    {
        Left=-1, Right =1
        //CarController에서 moveSpeed + / - 적용을 열거형식에 간단히 정의
        //if (direction == InputManager.Direction.Right)
        //{
        //    moveSpeed = 0.1f;
        //}
        //else if (direction == InputManager.Direction.Left)
        //{
        //    moveSpeed = -0.1f;
        //}
    }
    // 대리자 변수 정의
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
            float dirx = endPos.x - startPos.x; // 거리

            if (dirx > 0)
            {
                // swipeAction 주소 확인용
                // System.Action'1[InputManage+Diraction]
               // Debug.Log($"swipeAction: {swipeAction}");

                //대리자호출               
                this.swipeAction(Direction.Right);
            }
            else if (dirx < 0)
            {
                this.swipeAction(Direction.Left);
            }

            //오른쪽, 왼쪽 이동을 enum으로 정의 후 대리자 선언해서 간단하게 사용 
            /*
            if (dirX > 0)
            {
                Debug.Log($"오른쪽으로 {Mathf.Abs(dirX)}m이동합니다");
                moveSpeed = 0.05f;
            }
            else if (dirX < 0)
            {
                Debug.Log($"왼쪽으로 {Mathf.Abs(dirX)}m이동합니다");
                moveSpeed = -0.01f;
            }
            */

        }
    }
}
