using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    // 백터의 뺄셈의 연습
    // 필드를 만들자 a, b(GameObject)
    public GameObject A;
    public GameObject B;
    // a벡터(위치) = postion transform Gameobject
    // b벡터
   

    void Start()
    {
        //Debug.Log($"A: {A}");
        //Debug.Log($"B: {B}");
        // A.GetComponent<Transform>();
        // a,b의 월드 포지션
        Vector3 a = A.transform.position;
        Vector3 b = B.transform.position;
        Debug.Log($"A: {a}");
        Debug.Log($"B: {b}");

        // b - a = c
        Vector3 c = b - a; // 방향백터(크기, 방향)
        Debug.Log(c);

        DrawArrow.ForDebug(a,c,5,Color.yellow,ArrowType.Solid);



    }

}
