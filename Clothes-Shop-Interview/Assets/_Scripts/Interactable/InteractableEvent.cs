using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableEvent : MonoBehaviour, IInteractable
{

    [SerializeField] private UnityEvent unityEvent;

    public void Interact()
    {
        unityEvent?.Invoke();
    }

    public void OnSelected()
    {
    }

    public void OnUnselected()
    {
    }
}
