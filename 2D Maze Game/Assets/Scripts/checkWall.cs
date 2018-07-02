using UnityEngine;

public class checkWall : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "wall")
        {
            //Debug.Log("GAMEOVER");
        }
    }
}
