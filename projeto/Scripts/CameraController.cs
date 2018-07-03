using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
    public Transform start;
    private Vector3 offset;

	
	void Start ()
	{
		start = GameObject.FindWithTag("Respawn").transform;
        this.transform.position = start.position+new Vector3(0,2,-6);
        offset = transform.position - player.transform.position;

    }

	
	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}
}
//(0,0,0)