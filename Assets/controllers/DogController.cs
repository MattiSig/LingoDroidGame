using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogController : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    public float dogJumpForce = 500f;
    private Animator myAnim;
    public Text score;
    private double startTime;
    public AudioClip SoundToPlay;
    new AudioSource audio;



    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        startTime = Time.time;
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetButtonUp("Jump") && System.Math.Abs(myRigidbody.velocity.y)<1)
        {
            myRigidbody.AddForce(transform.up * dogJumpForce);
        }
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                myRigidbody.AddForce(transform.up * dogJumpForce);
            }
        }
        myAnim.SetFloat("vVelocity", System.Math.Abs(myRigidbody.velocity.y));
        score.text = (Time.time - startTime).ToString("0.0");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
      //      audio.PlayOneShot(SoundToPlay, 1);
            Application.LoadLevel(Application.loadedLevel);
        }


    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "BoneText(Clone)")
        {
            GameObject boneText = other.gameObject;
            var boneScript = boneText.transform.GetComponent<BoneController>();
            if(boneText.transform.GetChild(0).name == "bone")
            {
                Destroy(boneText.transform.GetChild(0).gameObject);
                boneScript.dogAteMe();
            }
        }
    }
}
