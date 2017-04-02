using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomControll : MonoBehaviour {
    public float speed = 1;
    // Use this for initialization
    private Canvas CanvasObject;
    void Start () {
        CanvasObject = GameObject.Find("Canvas").GetComponent<Canvas>();
        Debug.Log(CanvasObject);

    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.left * speed * Time.deltaTime;
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("jebbjebbNope");
        CanvasObject.enabled = true;
        /*if(other.gameObject.tag == "destroy")
        {
            Destroy(this.gameObject);
        }*/
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        CanvasObject.enabled = false;
    }
}
