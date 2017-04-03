using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    public float dogJumpForce = 500f;
    private Animator myAnim;
	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Bone"))
        {
            Destroy(collision.gameObject);
        }

    }

}
