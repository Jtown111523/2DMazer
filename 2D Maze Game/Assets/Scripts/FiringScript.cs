using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringScript : MonoBehaviour {

    GameObject bulletPrefab;

    Vector3 spawnLoc;

    public float bulletSpeed;

    private void Start()
    {
        bulletPrefab = (GameObject)Resources.Load("Bullet");
    }


    // Update is called once per frame
    void Update () {

        spawnLoc = this.gameObject.transform.position;

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, spawnLoc, Quaternion.identity);
            bullet.GetComponent<Transform>().rotation = this.gameObject.transform.rotation;
            Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
            bulletRB.velocity = bullet.transform.up * bulletSpeed;


        }
		
	}
}
