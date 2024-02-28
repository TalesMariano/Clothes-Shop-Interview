using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue : MonoBehaviour
{
    [ContextMenu("TestDialogue")]
    void TestDialogue22()
    {

        DialogueSystem.Instance.NewDialogue(new string[] { "Hello! Yes, I'm the shopkeeper!" });
    }
}
