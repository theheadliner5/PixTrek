using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aerial2DCharacterMovement : MonoBehaviour {

    public float speed = 3f;
    private Rigidbody2D rb2d;
    private Animator anim;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(hAxis * speed, vAxis * speed);
        rb2d.velocity = movement;
        anim.SetFloat("vAxis", vAxis);
        anim.SetFloat("hAxis", hAxis);
        if(Mathf.Abs(vAxis) >= Mathf.Abs(hAxis))
        {
            anim.SetBool("v_is_bigger", true);
        }
        else
        {
            anim.SetBool("v_is_bigger", false);
        }
	}

    
}
