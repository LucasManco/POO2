using UnityEngine;

// Include the namespace required to use Unity UI
using UnityEngine.UI;

using System.Collections;

public class PlayerController : MonoBehaviour {
    public MenuController menu;
	public float speed;
    public Transform start;

	private Rigidbody rb;
	

	void Start ()
	{
        start = GameObject.FindWithTag("Respawn").transform;
        rb = GetComponent<Rigidbody>();

        this.transform.position = start.position;
	}

	void FixedUpdate ()
	{

        //float moveHorizontal = Input.GetAxis ("Horizontal");
        //float moveVertical = Input.GetAxis ("Vertical");
        //Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        Vector3 movement = new Vector3();
        if (Input.GetKey(GameManager.GM.forward))

            movement += Vector3.forward;

        if (Input.GetKey(GameManager.GM.backward))

            movement += -Vector3.forward;

        if (Input.GetKey(GameManager.GM.left))

            movement += Vector3.left;

        if (Input.GetKey(GameManager.GM.right))

            movement += Vector3.right;

        if (Input.GetKeyDown(GameManager.GM.jump))

            movement += Vector3.up / 2;

        rb.AddForce (movement * speed);
        if (transform.position.y < -10)
        {
            menu.LoseGame();
        }
    }

	void OnTriggerEnter(Collider other) 
	{
		
		if (other.gameObject.CompareTag ("Finish"))
		{
            menu.WinGame();
		}
       
    }

	
}