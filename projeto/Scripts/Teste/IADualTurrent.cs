﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IADualTurrent : IA
{
    public Transform Mira1;
    public Transform Mira2;
    public Transform pDeslogado;
    private float vTiro;
    private float tTiro;
    private float nTiro;
	private int i;
	public GameObject temperature;
	public Temperature t;
    

    void Start()
    {	
		t=temperature.GetComponent<Temperature>();
        tTiro = 0.5f;
        vTiro = 0;
		nTiro = 5;
		i=0;
    }


    void Update()
    {
        tDelay += Time.deltaTime;

        if (!alvo)
        {
            alvo = GameObject.FindWithTag("Player").transform;
        }
        else
        {

            Distancia = Vector3.Distance(transform.position, alvo.position);
            if (Distancia < 20)
            {
                if (tDelay > 1)
                {

                    MiraAlvo2(alvo, E1, M, Time.deltaTime * 2);
                    vTiro += Time.deltaTime;
                    if (vTiro > tTiro && Distancia<10)
                    {
						if (i<nTiro&&!t.isOverloaded()){
							Atirar(Mira1, E1); 
							Atirar(Mira2, E1);
							vTiro = 0;
							i++;
						}
						else if (vTiro>Time.deltaTime*200) {
							i=0;
						}
						else {
							t.Overload();
							
						}

                    }

                }
                else MiraAlvo2(alvo, E1, M, Time.deltaTime * 2);
            }
            else
            {
                tDelay = 0;
                vTiro = 0;
                MiraAlvo2(pDeslogado, E1, M, Time.deltaTime);
            }

        }







    }
    


    
}



