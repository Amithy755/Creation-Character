using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{
    public string LabelText = "";

    public void OnGUI()
    {

        GUI.Box(new Rect(400, 100, 200, 250), "Players");

        if (GUI.Button(new Rect(450, 150, 100, 50), "Player 2"))
        {
            print("Player 2");
        }

        GUI.Box(new Rect(450, 250, 100, 100), "Name: Mage\n\rHealth: 1000\n\rAttack: 2500\n\rDefense: 2500");

    }


}