using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    Transform player;

    public float speed;

	// Use this for initialization
	void Start () {

        player = GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Vertical"))
        {
            //Debug.Log("Move player up or down");

            
        }
		
	}
}
