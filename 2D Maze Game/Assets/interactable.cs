using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Collider2D))]


public class interactable : MonoBehaviour {

    bool canInteract = false;

    public Text interactText;

    private void Start()
    {
        interactText = GameObject.Find("InteractText").GetComponent<Text>();
        interactText.text = "Press F To Interact";
        interactText.enabled = false;
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
            Debug.Log("Interacted");
        }
    }
}
