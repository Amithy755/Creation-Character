using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    public string LabelText = "";

    public void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 200, 250), "Players");

        if (GUI.Button(new Rect(150, 150, 100, 50), "Player 3"))
        {
            print("Player 3");

        }

        GUI.Box(new Rect(150, 250, 100, 100), "Name: Archer\n\rHealth: 1000\n\rAttack: 900\n\rDefense: 1500");

    }



}
