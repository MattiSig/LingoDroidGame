using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour {

    public GameObject tmp;

    public float time = 10; // tíminn sem texti er uppi.

	// Use this for initialization
	void Start () {
        Invoke("Hide", time);
	}

    void Hide()
    {
        // Fela tutorial.
        tmp.SetActive(false);
    }
	
}
