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
    
    public void Update()
    {
        Vector2 playerPos = new Vector2(player.position.x, player.position.y);
        if (Input.GetAxis("Vertical") > 0)
        {
            //move player up
            playerPos.y = playerPos.y + (speed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            //move player down
            playerPos.y = playerPos.y - (speed * Time.deltaTime);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            //move player right
            playerPos.x = playerPos.x + (speed * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            //move player left
            playerPos.x = playerPos.x - (speed * Time.deltaTime);
        }

        Vector2 newPlayerPos = new Vector2(playerPos.x, playerPos.y);

        this.transform.position = newPlayerPos;
    }
}
