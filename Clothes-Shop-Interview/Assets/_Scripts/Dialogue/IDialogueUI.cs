using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDialogueUI 
{
    void ShowUI();
    void HideUI();
    void ReceiveText(string text);
}
