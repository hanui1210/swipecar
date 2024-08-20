using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    // ������ ������ ����
    // �ʵ带 ������ a, b(GameObject)
    public GameObject A;
    public GameObject B;
    // a����(��ġ) = postion transform Gameobject
    // b����
   

    void Start()
    {
        //Debug.Log($"A: {A}");
        //Debug.Log($"B: {B}");
        // A.GetComponent<Transform>();
        // a,b�� ���� ������
        Vector3 a = A.transform.position;
        Vector3 b = B.transform.position;
        Debug.Log($"A: {a}");
        Debug.Log($"B: {b}");

        // b - a = c
        Vector3 c = b - a; // �������(ũ��, ����)
        Debug.Log(c);

        DrawArrow.ForDebug(a,c,5,Color.yellow,ArrowType.Solid);



    }

}
