using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class SpaceWordBank2 : MonoBehaviour
{

    private List<string> originalWords = new List<string>()
    {
        "particle", "travel", "matter", "space", "electric", "expand", "atom", "earth", "element", "telescope"
    };

    private List<string> workingWords = new List<string>();

    private void Awake()
    {
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
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
