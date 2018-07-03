using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

    public Image barraVidaUI;
    public float vidaMaxima = 10;
    public float vidaAtual;

	// Use this for initialization
	void Start () {
        vidaAtual = vidaMaxima;
	}
	
	// Update is called once per frame
	void Update () {
        if (vidaAtual >= vidaMaxima) vidaAtual = vidaMaxima;
        barraVidaUI.rectTransform.sizeDelta = new Vector2(vidaAtual/vidaMaxima * 100,20);
		
	}
}
