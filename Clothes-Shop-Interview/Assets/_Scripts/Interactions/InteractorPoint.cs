using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractorPoint : MonoBehaviour
{
    [SerializeField] private GameObject lastInteractable;

    void Update()
    {
        if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            if(lastInteractable != null)
            {
                InteractWithObject();
            }
        }
    }

    void InteractWithObject()
    {
        lastInteractable.GetComponent<IInteractable>().Interact();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Interactive Object"))
        {
            lastInteractable = col.gameObject;
            
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject == lastInteractable)
        {
            lastInteractable = null;
        }
    }
}
