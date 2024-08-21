using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class App2 : MonoBehaviour
{
  public InputManager inputManager;
    public CarController carController;
    public Transform flagTrans;
    public GameDirector gameDirector;
    

    public void Start()
    {
        // 테스트
        // 자동차와 깃발과의 거리를 출력
        float distanceX = CalcDistance();
        Debug.Log(distanceX);
        if (distanceX < 0)
        {
            Debug.Log("GameOver");
            this.GameOver();
        }
        else
        {
            Debug.Log(distanceX);
            this.UpdataDistanceUI(distanceX);
        }

        // public GameObject carGo; 
        //carGo.GetComponent<carController>();
        //=> public CarController carController; => 줄여서 사용가능

        // 람다식사용
        this.inputManager.swipeAction = (direction) => { 
        
            Debug.Log(direction); //=> 확인용 
            // App에서 먼저 시작하는지 Inputmanager에서 먼저 사용하는지 확인
            carController.Move(direction);

        };
        carController.moveAction = () =>
        {
          float distanceX =  CalcDistance();
            this.UpdataDistanceUI(distanceX);
        };
        carController.moveCompleteAction = () => {
            Debug.Log("이동완료");
        };
    }

    private float CalcDistance()
    {
        Vector3 carPos = carController.gameObject.transform.position; //a
        Vector3 flagPos = this.flagTrans.position; //b

        float distanceX = flagPos.x - carPos.x;
        return distanceX;
    }

    // 자동차 오브젝트와 깃발 오브젝트의 거리를 계산후 gameDiractor의 UpdataUI를 호출하는 메서드
    private void UpdataDistanceUI(float distanceX)
    {
        
        gameDirector.UpdateUI(distanceX);
    }
    private void GameOver()
    {
        gameDirector.UpdateUI("GameOver");
    }

}
