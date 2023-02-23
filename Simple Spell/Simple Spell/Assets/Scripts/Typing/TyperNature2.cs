using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TyperNature2 : MonoBehaviour
{

    public NatureWordBank2 wordBank = null;
    public TextMeshProUGUI wordOutput = null;

    private string remainingWord = string.Empty;
    private string currWord = string.Empty;

    public GameObject eff;

    // Start is called before the first frame update
    private void Start()
    {
        SetCurrWord();   
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
    }

    private void SetCurrWord()
    {
        // Get bank word
        currWord = wordBank.GetWord();
        SetRemainingWord(currWord);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }

    private void CheckInput()
    {
        if(Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if(keysPressed.Length == 1) 
                EnterLetter(keysPressed);
        }
    }

    private void EnterLetter(string TypedLetter)
    {
        if(IsCorrect(TypedLetter))
        {
            RemoveLetter();

            if (isComplete())
            {
                GameObject ef = Instantiate(eff, transform.position, Quaternion.identity) as GameObject;
                Destroy(ef, 2);
                SetCurrWord();
            }
        }
        else
        {
            SetRemainingWord(currWord);
        }
    }

    private bool IsCorrect(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool isComplete()
    {
        return remainingWord.Length == 0;
    }
}
