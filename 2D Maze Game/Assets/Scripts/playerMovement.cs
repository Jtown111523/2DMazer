using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody2D myRid;
    private float speed = 5;

    private void Start()
    {
        myRid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update ()
    {
        PlayerMove();
	}

    void PlayerMove()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            myRid.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, myRid.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            myRid.velocity = new Vector2(myRid.velocity.x, Input.GetAxisRaw("Vertical") * speed);
        }

        if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            myRid.velocity = new Vector2(0f, myRid.velocity.y);
        }

        if(Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            myRid.velocity = new Vector2(myRid.velocity.x, 0f);
        }
    }
}
