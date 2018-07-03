using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Collider2D))]


public class interactable : MonoBehaviour {

    public bool levelSelect;

    public bool openDoor;

    bool canInteract = false;

    [HideInInspector]
    public Text interactText;

    Collider2D interactArea;

    private void Start()
    {
        interactText = GameObject.Find("InteractText").GetComponent<Text>();
        interactText.text = "Press F To Interact";
        interactText.enabled = false;
        interactArea = GetComponent<Collider2D>();
        interactArea.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            //display text
            interactText.enabled = true;
            canInteract = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            //hide text
            interactText.enabled = false;
            canInteract = false;
        }
    }

    private void Update()
    {
        if (canInteract == true && Input.GetButtonDown("InteractButton"))
        {

            //need different types of interaction
            //can use check boxes to change for each Interaction
            //I.E. Create true/false public variables for each type of Interaction and then if it is true it will run it here
            //if false it will not run


            Debug.Log("Interacted");

            if (levelSelect)
            {
                //open up level selection screen
                Debug.Log("Bring Up Level Select Screen");
            }

            if (openDoor)
            {
                Debug.Log("Open Door");
            }

        }
    }
}
