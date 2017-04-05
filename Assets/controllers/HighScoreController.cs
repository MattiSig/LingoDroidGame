using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour {

    private string[,] test = { { "Kalli", "10"}, { "Maggi", "9" }, { "Jón", "8" }, { "Siggi", "7" }, { "Steve", "6" }, { "John", "5" }, { "Smith", "4" }, { "Doddi", "3" }, { "Finnur", "2" }, { "Arnór", "1" } };

    private Text[] HighRollers;

	// Use this for initialization
	void Start () {
        HighRollers = GetComponentsInChildren<Text>();
		for(int i=0;i<10;i++)
        {
            HighRollers[i].text = test[i,0];
            // Debug.Log("Uppfæri");
        }
        for (int i = 0; i < 10; i++)
        {
            HighRollers[i+10].text = test[i, 1];
            // Debug.Log("Uppfæri");
        }
    }
}
