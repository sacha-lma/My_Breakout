using System;
using System.Collections;
using System.Net.Mime;
using TMPro;
using UnityEngine;

public class Dialogs : MonoBehaviour
{
    public GameObject ball;
    public GameObject dialog;
    public TextMeshProUGUI text;
    public string[] dialogue;
    public GameObject nextButton;
    
    private int _index;
    private bool skipable;

    public float wordspeed;

    private void Start()
    {
        Time.timeScale = 1f;
        dialog.SetActive(true);
        StartCoroutine(Typing());
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.KeypadEnter) && skipable == true) || (Input.GetKeyDown(KeyCode.Return) && skipable == true))
        {
            NextLine();
        }
    }

    private void zeroTexte()
    {
        text.text = "";
        _index = 0;
        dialog.SetActive(false);
        ball.SetActive(true);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[_index].ToString())
        {
            text.text += letter;
            yield return new WaitForSeconds(wordspeed);
        }
        nextButton.SetActive(true);
        skipable = true;
    }

    public void NextLine()
    {
        if (_index < dialogue.Length - 1)
        {
            _index++;
            text.text = "";
            StartCoroutine(Typing());
            nextButton.SetActive(false);
            skipable = false;
        } else
        {
            skipable = false;
            zeroTexte();
        }
    }
}
