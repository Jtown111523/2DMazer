using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletOutOfRange : MonoBehaviour {

    public float timeToDestroy = 5.0f;

    private void Update()
    {
        timeToDestroy -= Time.deltaTime;

        if(timeToDestroy <= 0)
        {
            Debug.Log("Bullet Destroyed");
            Destroy(this.gameObject);
        }
        
    }
}
