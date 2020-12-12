using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public static int QuestionsCount = 0;
    public static int CorrectAnswers = 0;
    public static float ZombieCount = 0;
    public static bool isQuestionGenerated = false;
    public static bool isADone = false;
    public static bool isBDone = false;
    public static bool isCDone = false;
    public static bool isDDone = false;
    public static List<int> answers = new List<int>();


    //tofix shouldnt be here
    public Text[] answerBoxes;
}
