using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : MonoBehaviour
{
    public string LabelText = "";

    public void OnGUI()
    {
        GUI.Box(new Rect(700, 100, 200, 250), "Heroes");

        if (GUI.Button(new Rect(750, 150, 100, 50), "Player 1"))
        {
            print("Player 1");
        }

        GUI.Box(new Rect(750, 250, 130, 100), "Name: Swordsman\n\rHealth: 1000\n\rAttack: 2000\n\rDefense: 2000");

    }
}