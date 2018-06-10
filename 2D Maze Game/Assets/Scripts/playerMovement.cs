using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float velo = 5f;

	// Update is called once per frame
	void Update ()
    {
        PlayerMove();
	}

    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velo * Time.deltaTime);
        }

        /*
         * Need to change
         * Up will work as is
         * Side to side and down will only go up down and side to side in world space; not relative to the character
         * /


       /* else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velo * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * velo * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * velo * Time.deltaTime);
        }*/
    }
}
