using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TestDialogue22();
        }
    }

    [ContextMenu("TestDialogue")]
    void TestDialogue22()
    {

        DialogueSystem.Instance.NewDialogue(new string[] { "Hello! Yes, I'm the shopkeeper!" , "Lorem Ipsun", "Lorem Ipsun2" });
    }
}
