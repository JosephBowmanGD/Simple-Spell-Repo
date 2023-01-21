using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WordData : MonoBehaviour
{
    [SerializeField]
    private Text charText;

    [HideInInspector]
    public char charValue;

    private Button buttonObj;

    private void Awake()
    {
        buttonObj = GetComponent<Button>();

        if (buttonObj)
        {
            buttonObj.onClick.AddListener(() => CharSelected());
        }
    }

    public void SetChar(char Value)
    {
        charText.text = Value + "";
        charValue = Value;
    }

    private void CharSelected()
    {
        
    }
}
