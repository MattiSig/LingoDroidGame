using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public float speed = 7;
    // Use this for initialization
    private TextMesh[] textObject;
    private string[] stringArray = { "Matti", "Finnur", "Arnór", "Doddi", "ekkiOrð", "lærðuKrakki", "kuldinn", "myrkrið" };
    private GameObject buttPanel;
    private CanvasGroup buttons;
    void Start()
    {
        buttPanel = GameObject.Find("Canvas/ButtPanel");
        buttons = buttPanel.GetComponent<CanvasGroup>();
        textObject = GetComponentsInChildren<TextMesh>();
        int rndm = Random.Range(1, 8);
        textObject[0].text = stringArray[rndm];
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
            buttons.alpha = 1;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "rundog1")
        {
            buttons.alpha = 0;
        }
    }
}