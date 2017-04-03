using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneController : MonoBehaviour {

	public float speed = 1;
    private Vector3 MovingDirection = Vector3.up * 1;
    public float minSpeed = 3;
    public float maxSpeed = 13;
    float randomSpeed;
    private GameObject CanvasObject;
    private TextMesh[] textObject;
    private string[] stringArray = { "Matti", "Finnur", "Arnór", "Doddi", "ekkiOrð", "lærðuKrakki", "kuldinn", "myrkrið" };



    // Use this for initialization
    void Start () {
        randomSpeed = Random.Range(minSpeed, maxSpeed);
        CanvasObject = GameObject.Find("Canvas");
        //      Debug.Log(CanvasObject);
        textObject = GetComponentsInChildren<TextMesh>();
        int rndm = Random.Range(1, 8);
        textObject[0].text = stringArray[rndm];

    }

    // Update is called once per frame
    void Update () {

	    transform.position += Vector3.left * randomSpeed * Time.deltaTime;
        gameObject.transform.Translate(MovingDirection * randomSpeed * Time.smoothDeltaTime);

   

        if (gameObject.transform.position.y > 3)
        {
            MovingDirection = Vector3.down * 5/randomSpeed;
        }
        else if (gameObject.transform.position.y < -0.7)
        {
            MovingDirection = Vector3.up * 4/randomSpeed;
        }

  

    //   SpawnRandom.Spawn();

    }

}
