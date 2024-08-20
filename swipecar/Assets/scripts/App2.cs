using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App2 : MonoBehaviour
{
  public InputManager inputManager;
    public CarController carController;
    public Transform flagTrans;
    public GameDirector gameDirector;

    public void Start()
    {
        this.calcDistanceAndUpdataUI();
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
            this.calcDistanceAndUpdataUI();
        };
    }
    // 자동차 오브젝트와 깃발 오브젝트의 거리를 계산후 gameDiractor의 UpdataUI를 호출하는 메서드
    private void calcDistanceAndUpdataUI()
    {
        Vector3 carPos = carController.gameObject.transform.position; //a
        Vector3 flagPos=this.flagTrans.position; //b

        float distanceX = flagPos.x - carPos.x;
        gameDirector.UpdateUI(distanceX);
    }
}
