using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;

    // Queue is like an array, a FIFO collection (First in, first out)
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        // Name of NPC
        nameText.text = dialogue.name;

        // Clear sentences queue from old conversations
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        // Get the next sentence in the queue
        string sentence = sentences.Dequeue();
        // stops animating before we start animating new sentence
        StopAllCoroutines();
        
        StartCoroutine(TypeSentence(sentence));
    }

    // Coroutine that updates our text letter-by-letter
    IEnumerator TypeSentence (string sentence)
    {
        // set text to empty
        dialogueText.text = "";
        // converts string into character array
        foreach (char letter in sentence.ToCharArray())
        {
            // appends each letter to end of string
            dialogueText.text += letter;
            // wait 1 frame so it looks like its typing
            yield return null;
        }
    }

    void EndDialogue()
    {
         animator.SetBool("IsOpen", false);
    }
}
