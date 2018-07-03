using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
    public Rigidbody rb;
    RaycastHit hit;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.forward * 10000*Time.deltaTime;
        Destroy(gameObject,5);
        if (Physics.Raycast(transform.position,transform.forward,out hit))
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                hit.collider.gameObject.GetComponent<PlayerController>().menu.LoseGame();
            }
            
            print(Destroi(gameObject,"RayCast"));

        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collider = collision.collider.gameObject;
        PlayerController playerScript = collider.GetComponent<PlayerController>();
        if (collider.CompareTag("Player"))
        {
            playerScript.menu.LoseGame();
        }
        print(Destroi(gameObject,"Colision Enter"));
    }

    private string Destroi(GameObject quem, string frase) {
        Destroy(quem);
        return frase;
    }


}
