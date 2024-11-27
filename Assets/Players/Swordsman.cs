using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : MonoBehaviour
{
    public string LabelText = "";

    public void OnGUI()
    {
        GUI.Box(new Rect(55, 30, 125, 150), "Player");

        if (GUI.Button(new Rect(70, 55, 100, 50), "Swordsman"))
        {
            print("Swordsman");
        }

        GUI.Box(new Rect(70, 110, 100, 50), "Health: 1000\n\rAttack: 2000\n\rDefense: 2000");

    }
}