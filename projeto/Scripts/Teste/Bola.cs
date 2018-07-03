using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
    public float velocidade;
    public Transform helice;
    public Rigidbody rb;
    private Vector3 velocidadeAtual;
    // Use this for initialization
    void Start () {
        velocidade = 500*Time.deltaTime;
        rb = this.GetComponent<Rigidbody>();
	}
        
	// Update is called once per frame
	void Update () {
        //transform.Translate(0, 0, velocidade);
        helice.Rotate(0, 1000* Time.deltaTime, 0);
        velocidadeAtual = velocidadeAtual * 0;
        if (Input.GetKey("w"))
        {
            //transform.Translate(0, 0, velocidade);
            velocidadeAtual += (velocidade*transform.forward);
        }
        if (Input.GetKey("s"))
        {
            velocidadeAtual += (velocidade * -transform.forward);
        }
        if (Input.GetKey("d"))
        {
            velocidadeAtual += (velocidade * transform.right);
        }
        if (Input.GetKey("a"))
        {
            velocidadeAtual += (velocidade * -transform.right);
        }
        if (Input.GetKey("e"))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey("q"))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(key: KeyCode.Space))
        {
            velocidadeAtual += (velocidade*2 * transform.up);
        }
        if (velocidadeAtual != new Vector3()*0) { rb.velocity = velocidadeAtual; }
        //transform.Rotate(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);

    }
}
