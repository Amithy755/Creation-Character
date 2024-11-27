using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{
    public string LabelText = "";

    public void OnGUI()
    {

        GUI.Box(new Rect(200, 30, 125, 150), "Player");

        if (GUI.Button(new Rect(210, 60, 100, 50), "Mage"))
        {
            print("Mage");
        }

        GUI.Box(new Rect(210, 115, 100, 50), "Health: 1000\n\rAttack: 2500\n\rDefense: 2500");

    }


}