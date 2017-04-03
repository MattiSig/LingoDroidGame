using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {
    public bool isPaused = false;
    public void Start()
    {
        Time.timeScale = 1;
    }
    public void OnClick()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            
        } else
        {
            Time.timeScale = 1;
        }
    }

}
