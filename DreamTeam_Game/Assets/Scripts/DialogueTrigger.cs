using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        // Using a singleton pattern would be an optimised way of doing this
        // But doing it this way for now
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
