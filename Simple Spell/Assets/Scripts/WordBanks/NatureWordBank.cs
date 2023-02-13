using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class NatureWordBank : MonoBehaviour
{

    private List<string> originalWords = new List<string>()
    {
        "bat", "fox", "pig", "bug", "duck", "water", "cow", "stick", "tree", "grow", "hen", "pet", "plow", "snow"
    };

    private List<string> workingWords = new List<string>();

    private void Awake()
    {
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        Convert(workingWords);
    }

    private void Shuffle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temp = list[i];

            list[i] = list[random];
            list[random] = temp;
        }
    }

    private void Convert(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string GetWord()
    {
        string newWord = string.Empty;

        if(workingWords.Count != 0) 
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }

        return newWord;
    }
}
