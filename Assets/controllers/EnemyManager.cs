using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public float speed = 5;
    private TextMesh[] textObject;
    private string word;
    private GameObject buttonGroup;
    private CanvasGroup buttonAlpha;
    private Text[] buttonTexts;
    private Component[] buttonScripts;

    void Start()
    {
        buttonGroup = GameObject.Find("EnemySpawn/Canvas/ButtPanel");
        buttonAlpha = buttonGroup.GetComponent<CanvasGroup>();
        textObject = GetComponentsInChildren<TextMesh>();
        int rndm = Random.Range(1, 8);
        textObject[0].text = word;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "rundog1")
        {
            buttonAlpha.alpha = 1;
            Time.timeScale = 0.5F;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "rundog1")
        {
            buttonAlpha.alpha = 0;
            Time.timeScale = 1F;
        }
    }
    public void setWord(string a)
    {
        word = a;
    }
    public void setButtonText(string[,] words)
    {
        buttonGroup = GameObject.Find("EnemySpawn/Canvas/ButtPanel");
        buttonTexts = buttonGroup.GetComponentsInChildren<Text>(); 
        Debug.Log(buttonTexts);
        for(int j = 0; j < buttonTexts.Length; j++)
        {
            buttonTexts[j].text = words[j, 0];
            if (words[j, 2] == "t")
            {
                word = words[j, 1];
                var buttonScript = buttonGroup.transform.GetChild(j).GetComponent<ButtonClick>();
                buttonScript.setRightOne();
                buttonScript.shroom = transform; 
            }
        }
    }
}