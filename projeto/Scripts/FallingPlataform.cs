using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlataform : MonoBehaviour {
	private Rigidbody rb;
	private int speed;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		speed = 5;
	}
	
	
	void OnCollisionEnter(Collision collidedWithThis)
 {
     if (collidedWithThis.transform.name == "Sphere")
     {
         //first method
         Vector3 movement = new Vector3 (0.0f, -35.0f, 0.0f);
         rb.AddForce (movement * speed);
         //second method
         rb.velocity = transform.up * -speed;
     }
 }
}
