using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour {
    private bool theRightOne = false;
    public Transform shroom;
    public Transform dog;
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}
    public void setRightOne()
    {
        theRightOne = true;
    }
    public void OnClick()
    {
        if (theRightOne)
        {
            Debug.Log("RÉTT!");
        } else {
            Debug.Log("RANGT!");
        }
    }
}
