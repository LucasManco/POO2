using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour {
    public Transform alvo;
    public Transform E1;
    public Transform M;
    public float Distancia;
    public float tDelay;
    public GameObject bala;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MiraAlvo(Transform onde, Transform Eixo1, Transform Eixo2, Transform Mira, float delay)
    {
        Mira.LookAt(onde);
        Eixo1.transform.Rotate(0, Mira.eulerAngles.y - Eixo2.eulerAngles.y, 0);
        Eixo2.transform.Rotate(Mira.eulerAngles.x - Eixo2.eulerAngles.x, 0, 0);

    }

    public void MiraAlvo2(Transform onde, Transform Arma, Transform Mira, float delay)
    {
        Mira.LookAt(onde);
        Arma.rotation = Quaternion.Lerp(Arma.rotation, Mira.rotation, delay);

    }

    public void Atirar(Transform Mira, Transform Eixo2)
    {
        Instantiate(bala, Mira.position, Eixo2.rotation);
    }

    public void rotacionaEixo(Transform Eixo, float vRotacao)
    {
        Eixo.transform.Rotate(0, 0, vRotacao * Time.deltaTime);
    }
}
