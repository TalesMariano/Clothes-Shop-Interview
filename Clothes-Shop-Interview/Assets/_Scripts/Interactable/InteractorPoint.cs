using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractorPoint : MonoBehaviour
{
    [SerializeField] private IInteractable lastInteractable;

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
        lastInteractable.Interact();
    }

    void SelectInteractable(IInteractable interactable)
    {
        lastInteractable = interactable;
        interactable.OnSelected();
    }

    void UnselectInteractable()
    {
        lastInteractable?.OnUnselected();
        lastInteractable = null;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Interactive Object"))
        {
            if (lastInteractable != null) UnselectInteractable();
            SelectInteractable(col.GetComponent<IInteractable>());            
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.GetComponent<IInteractable>() == lastInteractable)
        {
            UnselectInteractable();
        }
    }
}
