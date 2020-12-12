using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour
{
    public static void PrintAnswers(List<int> answers, Text[] answerBoxes)
    {
        for (int i = 0; i < 4; i++)
        {
            int randomIndex = Random.Range(0, 4 - i);
            if(i == 0)
            {
                answerBoxes[i].text = "A) " + answers[randomIndex].ToString();
            }
            else if (i == 1)
            {
                answerBoxes[i].text = "B) " + answers[randomIndex].ToString();
            }
            else if (i == 2)
            {
                answerBoxes[i].text = "C) " + answers[randomIndex].ToString();
            }
            else
            {
                answerBoxes[i].text = "D) " + answers[randomIndex].ToString();
            }
            answers.RemoveAt(randomIndex);
        }
    }
}
