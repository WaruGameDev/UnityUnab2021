using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
     

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogo")]
    public List<string> dialogos;
    public int index;
    
    [Header("Elementos interfaz")]
    public TextMeshProUGUI dialogoText;

    private void Start()
    {
        ShowDialogue();
    }

    public void ShowDialogue()
    {
        dialogoText.text = dialogos[index];
    }
    public void NextDialogue()
    {
        index++;
        if(index < dialogos.Count)
        {
            ShowDialogue();
        }
        else
        {
            index = 0;
            ShowDialogue();
        }
    }
}
