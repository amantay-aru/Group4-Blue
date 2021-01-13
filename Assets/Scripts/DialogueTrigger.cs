using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public GameObject StartButton = null;
    public GameObject Pointer = null;

    void Start()
    {
        StartButton.SetActive(false);
        Pointer.SetActive(false);
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void OnTriggerEnter(Collider other)
    {
        StartButton.SetActive(true);
        Pointer.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        StartButton.SetActive(false);
        Pointer.SetActive(false);
    }
}
