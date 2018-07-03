using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour {
    public GameObject bala;
    public Transform escape;
    public Ray raio;
    public RaycastHit ponto;
    public Camera cam;
    public Vector3 metrosFrente;
    public double tSegundos;
    public float tempoTiro;
    public Vector2 posMouse;
	// Use this for initialization
	void Start () {
        tSegundos =(1.0 / tSegundos);
	}
	
	// Update is called once per frame
	void Update () {


        posMouse = Input.mousePosition;
        if (posMouse.y < 120) posMouse.y = 120;
        raio = cam.ScreenPointToRay(posMouse);
        if (Physics.Raycast(raio,out ponto,100)) {

            transform.LookAt(ponto.point);
            
        }
        else
        {
            metrosFrente = cam.transform.position + raio.direction*50;
            transform.LookAt(metrosFrente);
        }

        if (Input.GetMouseButton(0)&& tempoTiro>tSegundos)
        {

            Instantiate(bala, escape.position, escape.rotation);
            tempoTiro = 0;
        }
        tempoTiro = tempoTiro + Time.deltaTime;
    }
}
