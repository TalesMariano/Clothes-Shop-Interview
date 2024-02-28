using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;


    bool visible = false;

    string[] currentDialogue;
    int currentLine = 0;


    public static DialogueSystem Instance { get; private set; }

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Update()
    {
        if (!visible)
            return;

        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            //AdvandeDialogue();
        }
    }

    [ContextMenu("TestDialogue")]
    void TestDialogue()
    {
        dialogueUI.ShowUI();
        NewDialogue( new string[]{ "Lorem Ipsun", "Lorem Ipsun2" });
    }

    void StartText()
    {
        StartDialogue();
        currentLine = 0;
        AdvandeDialogue();
    }



    public void NewDialogue(string[] dialogue )
    {
        currentDialogue = dialogue;
        StartText();
    }

    public void NewDialogue(string[] dialogue, UnityEvent event1)
    {
        currentDialogue = dialogue;
        StartText();
    }

    public void AdvandeDialogue()   // Remove public
    {
        if (currentDialogue== null || currentLine >= currentDialogue.Length)
        {
            EndDialogue();
            return;
        }

        dialogueUI.ReceiveText(currentDialogue[currentLine]);
        currentLine++;
    }

    public void StartDialogue()
    {
        visible = true;

        Time.timeScale = 0;

        dialogueUI.ShowUI();
    }

    public void EndDialogue()
    {
        visible = true;

        Time.timeScale = 1;

        dialogueUI.HideUI();
    }

}
