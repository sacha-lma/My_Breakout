using System;
using System.Collections;
using System.Net.Mime;
using TMPro;
using UnityEngine;

public class Dialogs : MonoBehaviour
{
    public GameObject dialog;
    public TextMeshProUGUI text;
    public string[] dialogue;
    public GameObject nextButton;
    
    private int _index;

    public float wordspeed;

    private void Start()
    {
        dialog.SetActive(true);
        StartCoroutine(Typing());
    }

    public void zeroTexte()
    {
        text.text = "";
        _index = 0;
        dialog.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[_index].ToString())
        {
            text.text += letter;
            yield return new WaitForSeconds(wordspeed);
        }
        nextButton.SetActive(true);
    }

    public void NextLine()
    {
        if (_index < dialogue.Length - 1)
        {
            _index++;
            text.text = "";
            StartCoroutine(Typing());
            nextButton.SetActive(false);
        } else
        {
            zeroTexte();
        }
    }
}
