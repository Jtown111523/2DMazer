using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

  public Transform playerPos;

    Vector3 offset = new Vector3(0, 0, -10);


	// Update is called once per frame
	void Update () {

        Vector3 cameraPos = playerPos.position + offset;

        this.transform.position = cameraPos;
		
	}
}
