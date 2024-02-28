using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour, IDialogueUI
{
    [SerializeField] private TMP_Text textBox;
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private GameObject choiceBox;



    private void Start()
    {
        HideUI();
    }


    public void HideUI()
    {
        canvasGroup.alpha = 0;
    }

    public void ReceiveText(string text)
    {
        textBox.text = text;
    }



    public void ShowUI()
    {
        canvasGroup.alpha = 1;
    }

    [ContextMenu("EnableChoiceBox")]
    public void EnableChoiceBox()
    {
        choiceBox.SetActive(true);
    }

    [ContextMenu("DisableChoiceBox")]
    public void DisableChoiceBox()
    {
        choiceBox.SetActive(false);
    }
}
