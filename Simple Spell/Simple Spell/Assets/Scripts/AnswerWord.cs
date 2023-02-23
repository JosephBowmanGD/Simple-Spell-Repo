using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerWord : MonoBehaviour
{
    public TextMeshProUGUI answerWord;
    public NatureWordBank1 wordBank = null;

    private void SetCurrWord()
    {
        //answerWord = wordBank.GetWord();
    }
}
