using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;


    bool visible = false;

    string[] currentDialogue;
    int currentLine = 0;


    [ContextMenu("TestDialogue")]
    void TestDialogue()
    {
        dialogueUI.ShowUI();
        NewDialogue( new string[]{ "Lorem Ipsun", "Lorem Ipsun2" });
    }

    void StartText()
    {
        ShowUI();
        currentLine = 0;
        AdvandeDialogue();
    }

    private void Update()
    {
        if (!visible)
            return;

        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            AdvandeDialogue();
        }
    }

    void NewDialogue(string[] dialogue)
    {
        currentDialogue = dialogue;
        StartText();
    }

    void AdvandeDialogue()
    {
        if (currentLine >= currentDialogue.Length)
        {
            dialogueUI.HideUI();
            return;
        }

        dialogueUI.ReceiveText(currentDialogue[currentLine]);
        currentLine++;
    }

    public void ShowUI()
    {
        visible = true;

        dialogueUI.ShowUI();
    }

    public void HideUI()
    {
        visible = true;
        dialogueUI.HideUI();
    }

}
