using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    //Options
    public GameObject continueButton = null;
    public GameObject option_1 = null;
    public GameObject option_2 = null;
    public GameObject option_3 = null;
    

    void Start()
    {
        sentences = new Queue<string>();
        
        option_1.SetActive(false);
        option_2.SetActive(false);
        option_3.SetActive(false);


        Button button1 = option_1.GetComponent<Button>();
        Button button2 = option_2.GetComponent<Button>();
        Button button3 = option_3.GetComponent<Button>();
        
    }


    public void StartDialogue(Dialogue dialogue)
    {
        //option_1.GetComponentInChildren<Text>().text = "Continue";

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
            {
            sentences.Enqueue(sentence);
        }

        DisplaynextSentence();
    }

    public void DisplaynextSentence()
    {
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

        if (sentences.Count == 0)
        {
            continueButton.SetActive(false);
            ShowOptions();
            return;
        }
    }

    public void ShowOptions()
    {
        option_1.SetActive(true);
        option_1.GetComponentInChildren<TMP_Text>().text = "New";
    }


    public void EndDialogue()
    {
        Debug.Log("End of the dialogue.");
    }
}