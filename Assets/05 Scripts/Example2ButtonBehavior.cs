using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Example2ButtonBehavior : MonoBehaviour
{
    public GameObject[] buttons; //Assigned in Start()

    [Header("Individual buttons")] //Assigned in editor
    public GameObject A_Button;
    public GameObject B_Button;
    public GameObject C_Button;
    public GameObject D_Button;

    [Header("Sounds")] //Assigned in editor
    public AudioSource rightSound;
    public AudioSource wrongSound;

    [Header("Animator")] //Assigned in editor
    public Animator buttonAnimator;

    [Header("User response")] //Assigned in public voids
    #region User response
    public int q1_1;
    public int q1_2;
    #endregion

    public int currentQuestion; //Assigned in Start()

    public float timer; //Assign in editor

    //Assigned in Start()
    #region Bools 
    public bool firstButtonPressed;
    public bool alreadyUsedButton;
    public bool responsesRecorded;
    #endregion

    void Start()
    {
        buttons = GameObject.FindGameObjectsWithTag("button");

        currentQuestion = 1;
        
        q1_1 = 0;
        q1_2 = 0;

        firstButtonPressed = false;
        alreadyUsedButton = false;
        responsesRecorded = false;

        if (gameObject.name == "A" || gameObject.name == "D")
        {
            buttonAnimator.Play("buttonFlash");
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnFirstButtonPressed()
    {
        //check if any button has been pressed yet, only run if no buttons have been pressed
        //record that first button got pressed, and record which button it was
        //record the answer for the excel file
        if (firstButtonPressed == false)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Example2ButtonBehavior>().firstButtonPressed = true;
            }

            alreadyUsedButton = true;

            #region Q1
            if (currentQuestion == 1)
            {
                q1_1 = 1;
            }
            #endregion
        }
    }

    public void OnSecondButtonPressed()
    {
        //record the answer for the excel file
        //record that the second button has been pressed
        //play sounds for right or wrong answer
        //play animation for shapes
        //change geometry
        if (firstButtonPressed == true && alreadyUsedButton == false)
        {
            //Just for button color animation
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Example2ButtonBehavior>().responsesRecorded = true;
            }

            #region Q1
            if (currentQuestion == 1)
            {
                q1_2= 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<Example2ButtonBehavior>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (D_Button.GetComponent<Example2ButtonBehavior>().q1_1 == 1 && A_Button.GetComponent<Example2ButtonBehavior>().q1_2 == 1)
                {
                    rightSound.Play();
                }

                else if (A_Button.GetComponent<Example2ButtonBehavior>().q1_1 == 1 && D_Button.GetComponent<Example2ButtonBehavior>().q1_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet1").GetComponent<Animator>().Play("problem2_example");

                //change geometry
                StartCoroutine(ChangeScene());
            }
            #endregion           
        }
    }

    //-------------- COROUTINES
    public IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Example2ButtonBehavior>().firstButtonPressed = false;
            buttons[i].GetComponent<Example2ButtonBehavior>().alreadyUsedButton = false;
            buttons[i].GetComponent<Example2ButtonBehavior>().responsesRecorded = false;
            buttons[i].GetComponent<Example2ButtonBehavior>().currentQuestion = 2;
        }

        SceneManager.LoadScene("Test 2");

    }

    public void ButtonColorAnimation()
    {
        if (responsesRecorded == false)
        {
            buttonAnimator.Play("originalToGrey");
        }
    }
}
