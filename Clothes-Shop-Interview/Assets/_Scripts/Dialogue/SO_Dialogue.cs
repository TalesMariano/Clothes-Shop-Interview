using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SO_Dialogue : ScriptableObject
{
    public string[] dialogueLines;

    public string[] GetLines()
    {
        return dialogueLines;
    }
}
