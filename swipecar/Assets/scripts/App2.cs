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
        //=> public CarController carController; => �ٿ��� ��밡��

        // ���ٽĻ��
        this.inputManager.swipeAction = (direction) => { 
        
            Debug.Log(direction); //=> Ȯ�ο� 
            // App���� ���� �����ϴ��� Inputmanager���� ���� ����ϴ��� Ȯ��
            carController.Move(direction);

        };
        carController.moveAction = () =>
        {
            this.calcDistanceAndUpdataUI();
        };
    }
    // �ڵ��� ������Ʈ�� ��� ������Ʈ�� �Ÿ��� ����� gameDiractor�� UpdataUI�� ȣ���ϴ� �޼���
    private void calcDistanceAndUpdataUI()
    {
        Vector3 carPos = carController.gameObject.transform.position; //a
        Vector3 flagPos=this.flagTrans.position; //b

        float distanceX = flagPos.x - carPos.x;
        gameDirector.UpdateUI(distanceX);
    }
}
