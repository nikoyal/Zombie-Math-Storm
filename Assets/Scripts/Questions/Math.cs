using UnityEngine;
using UnityEngine.UI;

public class Math : MonoBehaviour
{
    public static int Operation;
    public static int x;
    public static int y;
    public static int result;
    public Text[] answerBoxes;
    public static bool reloading = false;

    void Update()
    {
        if (reloading == true || Player.health <= 0)
        {
            answerBoxes[0].text = "";
            answerBoxes[1].text = "";
            answerBoxes[2].text = "";
            answerBoxes[3].text = "";
        }
        else if (Data.isQuestionGenerated == false && reloading == false)
        {
            Operation = Random.Range(0, 2);
            if(Operation == 0)
            {
                SumOperation();
            }
            else if (Operation == 1)
            {
                SubOperation();
            }
            else if (Operation == 2)
            {

            }
            else if (Operation == 3)
            {

            }
        }
    }

    private void SubOperation()
    {
        x = Random.Range(0, 501);
        y = Random.Range(0, 501);
        if(x < y)
        {
            int saveX = x;
            x = y;
            y = saveX;
        }
        result = x - y;
        Data.answers.Add(result);
        for (int i = 0; i < 3; i++)
        {
            Data.answers.Add(result - Random.Range(1, 15));
        }
        Data.isQuestionGenerated = true;
        Answers.PrintAnswers(Data.answers, answerBoxes);
    }

    void SumOperation()
    {
        x = Random.Range(0, 501);
        y = Random.Range(0, 501);
        result = x + y;
        Data.answers.Add(result);
        for (int i = 0; i < 3; i++)
        {
            Data.answers.Add(result - Random.Range(1, 15));
        }
        Data.isQuestionGenerated = true;
        Answers.PrintAnswers(Data.answers,answerBoxes);
    }
}
