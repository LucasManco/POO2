using UnityEngine;

public class IATurrent :IA
{
    public Transform E2;
    public Transform E3;
    public Transform pDeslogado;
    public float vTiro;
    public float tTiro;
    public float vEixo;
   


    //public 

    // Use this for initialization
    void Start () {
        MiraAlvo(pDeslogado, E1, E2, M, 1);
        tTiro = 0.5f;
        vTiro = 0;
    }
	
	// Update is called once per frame
	void Update () {
        tDelay += Time.deltaTime;
        
		if (!alvo)
        {
            alvo = GameObject.FindWithTag("Player").transform;
        }
        else
        {
            Distancia = Vector3.Distance(transform.position, alvo.position);
            if (Distancia < 50)
            {
                vEixo = Mathf.Lerp(vEixo, 720, Time.deltaTime * 2);
                rotacionaEixo(E3, vEixo);
                if (tDelay>1)
                {
                    
                    MiraAlvo(alvo, E1, E2, M, 0.1f);
                    vTiro += Time.deltaTime;
                    if (vTiro > tTiro)
                    {
                        Atirar(M, E2);
                        vTiro = 0;


                    }
                    
                }
                else MiraAlvo(alvo, E1, E2, M,0.1f);
            }
            else
            {
                tDelay = 0;
                vTiro = 0;
                MiraAlvo(pDeslogado, E1, E2, M, 0.1f);
                vEixo = Mathf.Lerp(vEixo, 0, Time.deltaTime);
                rotacionaEixo(E3, vEixo);
            }

        }
        
        
    }

   

    


}

