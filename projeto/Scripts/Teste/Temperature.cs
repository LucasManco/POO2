using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour {
	public int i;
	public int OVERLOADTIME;
	public bool overloaded;
	// Use this for initialization
	void Start () {
		i=0;
		OVERLOADTIME = 5;
		overloaded = false;
		GetComponent<Renderer>().material.color = Color.green;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		i--;
		if (i>0) {
			GetComponent<Renderer>().material.color = Color.green;
			overloaded = false;
		}
	}
	
	public void Overload (){
		GetComponent<Renderer>().material.color = Color.red;
		i=OVERLOADTIME;
		overloaded = true;
	}
	public bool isOverloaded(){
		return overloaded;
	}
}
