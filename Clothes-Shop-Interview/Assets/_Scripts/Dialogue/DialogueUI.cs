using System.Collections;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DialogueUI : MonoBehaviour, IDialogueUI
{
    [SerializeField] private TMP_Text textBox;
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private GameObject choiceBox;

    [Space]
    [SerializeField]
    private Button invisibutton;

    [Space]
    [SerializeField] private Button buttonAdvanceDialogue;
    [SerializeField] private Button buttonChoice1;
    [SerializeField] private Button buttonChoice2;

    bool choiceBoxOpen = false;

    Action Button1Event;
    public UnityEvent event1;

    public UnityEvent event2;

    private void Start()
    {
        HideUI();

        buttonAdvanceDialogue.onClick.AddListener(UIAdvanceDialogue);
        buttonChoice1.onClick.AddListener(Button1Click);
        buttonChoice2.onClick.AddListener(Button2Click);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SelectInvisibutton();
        }
    }

    void Button1Click()
    {
        DisableChoiceBox();
        event1.Invoke();
        DialogueSystem.Instance.AdvandeDialogue();
    }

    void Button2Click()
    {
        DisableChoiceBox();
        event2.Invoke();
        DialogueSystem.Instance.AdvandeDialogue();
    }

    public void HideUI()
    {
        canvasGroup.alpha = 0;
    }

    public void ReceiveText(string text)
    {
        textBox.text = text;
    }

    public void ReceiveText(string text, bool showCoiceBox = false)
    {
        textBox.text = text;

        if (showCoiceBox) EnableChoiceBox();
    }



    public void ShowUI()
    {
        canvasGroup.alpha = 1;
    }

    [ContextMenu("EnableChoiceBox")]
    public void EnableChoiceBox()
    {
        choiceBox.SetActive(true);
        choiceBoxOpen = true;
        SelectInvisibutton();
    }

    [ContextMenu("DisableChoiceBox")]
    public void DisableChoiceBox()
    {
        choiceBox.SetActive(false);
        choiceBoxOpen = false;
    }

    void UIAdvanceDialogue()
    {
        if (choiceBoxOpen)
            return;

        DialogueSystem.Instance.AdvandeDialogue();
    }

    [ContextMenu("SelectInvisibutton")]
    void SelectInvisibutton()
    {
        EventSystem.current.SetSelectedGameObject(invisibutton.gameObject);
    }
}
