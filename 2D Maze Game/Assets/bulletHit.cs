using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        //if bullet hits an object that is part of the game environment... i.e. a desk or a wall or somewhere where the player cannot walk
        if(col.tag == "Environment")
        {
            Destroy(this.gameObject);
        }

        
    }



}
