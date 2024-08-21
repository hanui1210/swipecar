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
        // �׽�Ʈ
        // �ڵ����� ��߰��� �Ÿ��� ���
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
        //=> public CarController carController; => �ٿ��� ��밡��

        // ���ٽĻ��
        this.inputManager.swipeAction = (direction) => { 
        
            Debug.Log(direction); //=> Ȯ�ο� 
            // App���� ���� �����ϴ��� Inputmanager���� ���� ����ϴ��� Ȯ��
            carController.Move(direction);

        };
        carController.moveAction = () =>
        {
          float distanceX =  CalcDistance();
            this.UpdataDistanceUI(distanceX);
        };
        carController.moveCompleteAction = () => {
            Debug.Log("�̵��Ϸ�");
        };
    }

    private float CalcDistance()
    {
        Vector3 carPos = carController.gameObject.transform.position; //a
        Vector3 flagPos = this.flagTrans.position; //b

        float distanceX = flagPos.x - carPos.x;
        return distanceX;
    }

    // �ڵ��� ������Ʈ�� ��� ������Ʈ�� �Ÿ��� ����� gameDiractor�� UpdataUI�� ȣ���ϴ� �޼���
    private void UpdataDistanceUI(float distanceX)
    {
        
        gameDirector.UpdateUI(distanceX);
    }
    private void GameOver()
    {
        gameDirector.UpdateUI("GameOver");
    }

}
