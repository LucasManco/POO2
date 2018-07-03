using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentFactory : MonoBehaviour {
	public GameObject turrent1;
	public GameObject turrent2;
	public GameObject turrent3;
	public GameObject turrent4;
    public GameObject turrent5;

    bool x;
	int i;
	// Use this for initialization
	void Start () {
		x=true;
		i=1;
		i=Random.Range(1,5);
	}
	
	// Update is called once per frame
	void Update () {
        if (x)
        {
            switch (i)
            {
                case 1:
                    Instantiate(turrent1, this.transform.position, this.transform.rotation);
                    x = false;
                    break;
                case 2:
                    Instantiate(turrent2, this.transform.position, this.transform.rotation);
                    x = false;
                    break;
                case 3:
                    Instantiate(turrent3, this.transform.position, this.transform.rotation);
                    x = false;
                    break;
                case 4:
                    Instantiate(turrent4, this.transform.position, this.transform.rotation);
                    x = false;
                    break;
                case 5:
                    Instantiate(turrent5, this.transform.position, this.transform.rotation);
                    x = false;
                    break;


            }
        }
	}
}
