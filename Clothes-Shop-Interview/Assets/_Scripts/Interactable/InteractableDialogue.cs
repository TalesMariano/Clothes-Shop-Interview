using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableDialogue : MonoBehaviour, IInteractable
{
    [SerializeField] private string[] dialogue;

    [SerializeField] private UnityEvent eventButtonConfirm;

    public void Interact()
    {
        DialogueSystem.Instance.NewDialogue(dialogue);
    }

    public void OnSelected()
    {
    }

    public void OnUnselected()
    {
    }
}
