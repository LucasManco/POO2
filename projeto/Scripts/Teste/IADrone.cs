using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IADrone : IA {
    public Rigidbody Rb;
    public float vMovimentacao=10;
    public float limiteAltura;
    public float distanciaY;
    public Transform asa;

    // Use this for initialization
    void Start () {
        Rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!alvo)
        {
            alvo = GameObject.FindWithTag("Player").transform;
        }
        else
        {
            Distancia = Vector3.Distance(transform.position, alvo.position);
            distanciaY = transform.position.y - alvo.position.y;

            if (distanciaY<limiteAltura && distanciaY>-limiteAltura)
            {
                Rb.velocity = E1.forward * vMovimentacao;
            }
            else
            {
                if (distanciaY > limiteAltura) Rb.velocity = Vector3.up* -vMovimentacao/2;
                if (distanciaY < -limiteAltura) Rb.velocity = Vector3.up * vMovimentacao / 2;

                //asa.rotation = Quaternion.Lerp(asa.rotation,,1f);
            }
            MiraAlvo2(alvo,E1, M, Time.deltaTime*2);
            
        }
    }   
}
