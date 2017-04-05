using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneController : MonoBehaviour {

	public float speed = 1;
    private Vector3 MovingDirection = Vector3.up * 1;
    public float minSpeed = 3;
    public float maxSpeed = 13;
    private float randomSpeed;
    private TextMesh[] textObject;
    private string islWord;
    private string engWord;
    private double timer = 0;


    // Use this for initialization
    void Start () {
        randomSpeed = Random.Range(minSpeed, maxSpeed);
        textObject = GetComponentsInChildren<TextMesh>();
        int rndm = Random.Range(1, 8);
        textObject[0].text = engWord;
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
        if(Time.time -1.5 > timer && timer != 0)
        {
            Destroy(this.gameObject); 
        }

    }
    public void setIslWord(string a)
    {
        islWord = a;
    }
    public void setEngWord(string a)
    {
        engWord = a;
    }
    public void dogAteMe()
    {
        textObject[0].text = engWord + " = " + islWord;
        randomSpeed = 1F;
        timer = Time.time;
    }

}
