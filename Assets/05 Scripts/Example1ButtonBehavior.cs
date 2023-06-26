using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Example1ButtonBehavior : MonoBehaviour
{
    #region VARIABLES
    [Header("Animator")]
    public Animator buttonAnimator;//Assign in editor

    [Header("Sounds")]
    public AudioSource rightSound;//Assign in editor
    public AudioSource wrongSound;
    #region
    public GameObject[] buttons;//Assign in Start

    public GameObject A_Button;//Assign in editor
    public GameObject B_Button;
    public GameObject C_Button;
    public GameObject D_Button;
    public GameObject E_Button;
    #endregion

    [Header("Bools")]
    public bool buttonPressed;//Asisign in Start
    public bool waitingForResponse;

    public float timer;//Assign in editor

    private int counter;//Assign in Start

    #region user responses
    [Header("User responses")]//Assign in Start
    public int responseQ1;
    #endregion

    public GameObject correctAnswer;//Assign in Start
    public GameObject referenceShape;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        correctAnswer = GameObject.FindGameObjectWithTag("correctAnswer");
        referenceShape = GameObject.FindGameObjectWithTag("referenceShape");

        counter = 0;
        buttons = GameObject.FindGameObjectsWithTag("button");

        #region user response
        responseQ1 = 0;
        #endregion

        buttonPressed = false;
        waitingForResponse = true;

        if (gameObject.name == "D")
        {
            buttonAnimator.Play("buttonFlash");
        }
    }

    //turns button gray after pressed, updates values of buttonPressed, waitingForResponse, counter, and responseQX
    public void OnButtonPressed()
    {
        if (buttonPressed == false && waitingForResponse == true)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Example1ButtonBehavior>().buttonPressed = true;
                buttons[i].GetComponent<Example1ButtonBehavior>().waitingForResponse = false;
                buttons[i].GetComponent<Example1ButtonBehavior>().counter++;
            }

            buttonAnimator.Play("originalToGrey");

            #region Q1
            if (counter == 1)
            {                
                responseQ1 = 1;
            }
            #endregion
        }
    }


    //when button is unpressed, the correct shapes turn green, correct or incorrect sound plays, animation plays, and geometry changes
    public void OnButtonUnpressed()
    {     
        #region Q1
        if (buttonPressed == true && waitingForResponse == false && counter == 1)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Example1ButtonBehavior>().waitingForResponse = true;
            }

            //Sounds here
            if (D_Button.GetComponent<Example1ButtonBehavior>().responseQ1 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("Example1GeometrySet").GetComponent<Animator>().Play("Example1Animations");
            GameObject.FindGameObjectWithTag("correctAnswer").GetComponent<Animator>().Play("originalToGreen");
            GameObject.FindGameObjectWithTag("referenceShape").GetComponent<Animator>().Play("originalToGreen");

            StartCoroutine(ChangingScene());
            
        }
        #endregion

    }
    //------ Change Scene
    public IEnumerator ChangingScene()
    {
        yield return new WaitForSeconds(timer);
        SceneManager.LoadScene("Test 1");
    }
}
