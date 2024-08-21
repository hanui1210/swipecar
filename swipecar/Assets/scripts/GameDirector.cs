using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    // UI를 갱신
    // using UnityEngine.UI; 
    public Text text;

    public void UpdateUI(float distance)
    {
        text.text = $"{(int)distance}m";
        // convert , Mathf, int parse 사용가능 
    }
    public void UpdateUI(string message)
    {
        text.text = message ;
    }

}
