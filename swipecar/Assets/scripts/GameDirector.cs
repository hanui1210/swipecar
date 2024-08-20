using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    // UI¸¦ °»½Å
    // using UnityEngine.UI; 
    public Text text;

    public void UpdateUI(float distance)
    {
        text.text = $"{distance}m";
    }

}
