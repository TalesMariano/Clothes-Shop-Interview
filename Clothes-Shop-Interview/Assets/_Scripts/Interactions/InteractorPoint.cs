using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractorPoint : MonoBehaviour
{
    [SerializeField] private GameObject lastInteractable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            if(lastInteractable != null)
            {
                print(" Interact with " + lastInteractable.name);
            }
        }
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
