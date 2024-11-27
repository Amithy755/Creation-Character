using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    public string LabelText = "";

    public void OnGUI()
    {
        GUI.Box(new Rect(350, 30, 125, 150), "Player");

        if (GUI.Button(new Rect(360, 60, 100, 50), "Archer"))
        {
            print("Archer");

        }

        GUI.Box(new Rect(360, 115, 100, 50), " Health: 1000\n\rAttack: 900\n\rDefense: 1500");

    }



}
