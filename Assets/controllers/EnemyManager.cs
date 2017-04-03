using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float speed = 5;
    // Use this for initialization
    private GameObject CanvasObject;
    private TextMesh[] textObject;
    private string[] stringArray = { "Matti", "Finnur", "Arnór", "Doddi", "ekkiOrð", "lærðuKrakki", "kuldinn", "myrkrið" };
    void Start()
    {
        CanvasObject = GameObject.Find("Canvas");   
//      Debug.Log(CanvasObject);
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
        CanvasObject.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        CanvasObject.SetActive(false);
    }
}