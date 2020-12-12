using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIQuestionScript : MonoBehaviour
{
    AudioSource Audio;
    Text question;
    public GameObject reloadingUI;
    public GameObject Buttons;

    void Awake()
    {
        reloadingUI = GameObject.Find("Reload");
    }
    void Start()
    {
        Buttons = GameObject.Find("Buttons");
        reloadingUI = GameObject.Find("Reload");
        question = GetComponent<Text>();
        Audio = GetComponent<AudioSource>();
        reloadingUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.health <= 0)
        {
            question.text = "";
            Buttons.SetActive(true);
        }
        else Buttons.SetActive(false);

        if (Math.reloading == true && Player.health > 0)
        {
            reloadingUI.SetActive(true);
            question.text = "";
        }
        else if(Math.Operation == 0 && Player.health > 0)
        {
            StartCoroutine(PlayReloadingAudio());
            reloadingUI.SetActive(false);
            //Destroy(reloadingUI);
            question.text = Math.x + " + " + Math.y;
            Data.QuestionsCount += 1;
        }
        else if (Math.Operation == 1 && Player.health > 0)
        {
            StartCoroutine(PlayReloadingAudio());
            reloadingUI.SetActive(false);
            //Destroy(reloadingUI);
            question.text = Math.x + " - " + Math.y;
            Data.QuestionsCount += 1;
        }
    }
    IEnumerator PlayReloadingAudio()
    {
        //need fixin
        if(Data.CorrectAnswers < 3)
        {
            yield return new WaitForSeconds(1.5f);
            Audio.Play(0);
        }
    }
}
