using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class problem1ButtonBehavior : MonoBehaviour
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
    public int responseQ2;
    public int responseQ3;
    public int responseQ4;
    public int responseQ5;
    public int responseQ6;
    public int responseQ7;
    public int responseQ8;
    public int responseQ9;
    public int responseQ10;
    public int responseQ11;
    public int responseQ12;
    #endregion

    [Header ("Timers")]
    #region timers
    public float timerQ1;
    public float timerQ2;
    public float timerQ3;
    public float timerQ4;
    public float timerQ5;
    public float timerQ6;
    public float timerQ7;
    public float timerQ8;
    public float timerQ9;
    public float timerQ10;
    public float timerQ11;
    public float timerQ12;
    #endregion

    public GameObject[] correctAnswers;//Assign in Start
    public GameObject[] referenceShapes;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        correctAnswers = GameObject.FindGameObjectsWithTag("correctAnswer");
        referenceShapes = GameObject.FindGameObjectsWithTag("referenceShape");

        counter = 0;
        buttons = GameObject.FindGameObjectsWithTag("button");

        #region user response
        responseQ1 = 0;
        responseQ2 = 0;
        responseQ3 = 0;
        responseQ4 = 0;
        responseQ5 = 0;
        responseQ6 = 0;
        responseQ7 = 0;
        responseQ8 = 0;
        responseQ9 = 0;
        responseQ10 = 0;
        responseQ11= 0;
        responseQ12 = 0;
        #endregion

        #region timers
        timerQ1 = 0;
        timerQ2 = 0;
        timerQ3 = 0;
        timerQ4 = 0;
        timerQ5 = 0;
        timerQ6 = 0;
        timerQ7 = 0;
        timerQ8 = 0;
        timerQ9 = 0;
        timerQ10 = 0;
        timerQ11 = 0;
        timerQ12 = 0;
    #endregion

        buttonPressed = false;
        waitingForResponse = true;
    }

    private void Update()
    {
        #region timers update
        if (counter == 0)
        {
            timerQ1 += Time.deltaTime;
        }

        if (counter == 1)
        {
            timerQ2 += Time.deltaTime;
        }

        if (counter == 2)
        {
            timerQ3 += Time.deltaTime;
        }

        if (counter == 3)
        {
            timerQ4 += Time.deltaTime;
        }

        if (counter == 4)
        {
            timerQ5 += Time.deltaTime;
        }

        if (counter == 5)
        {
            timerQ6 += Time.deltaTime;
        }

        if (counter == 6)
        {
            timerQ7 += Time.deltaTime;
        }

        if (counter == 7)
        {
            timerQ8 += Time.deltaTime;
        }

        if (counter == 8)
        {
            timerQ9 += Time.deltaTime;
        }

        if (counter == 9)
        {
            timerQ10 += Time.deltaTime;
        }

        if (counter == 10)
        {
            timerQ11 += Time.deltaTime;
        }

        if (counter == 11)
        {
            timerQ12 += Time.deltaTime;
        }
        #endregion
    }

    //turns button gray after pressed, updates values of buttonPressed, waitingForResponse, counter, and responseQX
    public void OnButtonPressed()
    {
        if (buttonPressed == false && waitingForResponse == true)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = true;
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = false;
                buttons[i].GetComponent<problem1ButtonBehavior>().counter++;
            }

            buttonAnimator.Play("originalToGrey");

            #region Q1
            if (counter == 1)
            {                
                responseQ1 = 1;
            }
            #endregion

            #region Q2
            if (counter == 2)
            {
                responseQ2 = 1;
            }
            #endregion

            #region Q3
            if (counter == 3)
            {
                responseQ3 = 1;
            }
            #endregion

            #region Q4
            if (counter == 4)
            {
                responseQ4 = 1;
            }
            #endregion

            #region Q5
            if (counter == 5)
            {
                responseQ5 = 1;
            }
            #endregion

            #region Q6
            if (counter == 6)
            {
                responseQ6 = 1;
            }
            #endregion

            #region Q7
            if (counter == 7)
            {
                responseQ7 = 1;
            }
            #endregion

            #region Q8
            if (counter == 8)
            {
                responseQ8 = 1;
            }
            #endregion

            #region Q9
            if (counter == 9)
            {
                responseQ9 = 1;
            }
            #endregion

            #region Q10
            if (counter == 10)
            {
                responseQ10 = 1;
            }
            #endregion

            #region Q11
            if (counter == 11)
            {
                responseQ11 = 1;
            }
            #endregion

            #region Q12
            if (counter == 12)
            {
                responseQ12 = 1;
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
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (A_Button.GetComponent<problem1ButtonBehavior>().responseQ1 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet1").GetComponent<Animator>().Play("Q1");

            StartCoroutine(ChangeGeometry1());
        }
        #endregion

        #region Q2
        if (buttonPressed == true && waitingForResponse == false && counter == 2)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (E_Button.GetComponent<problem1ButtonBehavior>().responseQ2 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet2").GetComponent<Animator>().Play("Q2");

            StartCoroutine(ChangeGeometry2());
        }
        #endregion

        #region Q3
        if (buttonPressed == true && waitingForResponse == false && counter == 3)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (A_Button.GetComponent<problem1ButtonBehavior>().responseQ3 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet3").GetComponent<Animator>().Play("Q3");

            StartCoroutine(ChangeGeometry3());
        }
        #endregion

        #region Q4
        if (buttonPressed == true && waitingForResponse == false && counter == 4)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (B_Button.GetComponent<problem1ButtonBehavior>().responseQ4 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet4").GetComponent<Animator>().Play("Q4");

            StartCoroutine(ChangeGeometry4());
        }
        #endregion

        #region Q5
        if (buttonPressed == true && waitingForResponse == false && counter == 5)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (C_Button.GetComponent<problem1ButtonBehavior>().responseQ5 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet5").GetComponent<Animator>().Play("Q5");

            StartCoroutine(ChangeGeometry5());
        }
        #endregion

        #region Q6
        if (buttonPressed == true && waitingForResponse == false && counter == 6)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (C_Button.GetComponent<problem1ButtonBehavior>().responseQ6 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet6").GetComponent<Animator>().Play("Q6");

            StartCoroutine(ChangeGeometry6());
        }
        #endregion

        #region Q7
        if (buttonPressed == true && waitingForResponse == false && counter == 7)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (B_Button.GetComponent<problem1ButtonBehavior>().responseQ7 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet7").GetComponent<Animator>().Play("Q7");

            StartCoroutine(ChangeGeometry7());
        }
        #endregion

        #region Q8
        if (buttonPressed == true && waitingForResponse == false && counter == 8)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (D_Button.GetComponent<problem1ButtonBehavior>().responseQ8 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet8").GetComponent<Animator>().Play("Q8");

            StartCoroutine(ChangeGeometry8());
        }
        #endregion

        #region Q9
        if (buttonPressed == true && waitingForResponse == false && counter == 9)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (E_Button.GetComponent<problem1ButtonBehavior>().responseQ9 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet9").GetComponent<Animator>().Play("Q9");

            StartCoroutine(ChangeGeometry9());
        }
        #endregion

        #region Q10
        if (buttonPressed == true && waitingForResponse == false && counter == 10)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (D_Button.GetComponent<problem1ButtonBehavior>().responseQ10 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet10").GetComponent<Animator>().Play("Q10");

            StartCoroutine(ChangeGeometry10());
        }
        #endregion

        #region Q11
        if (buttonPressed == true && waitingForResponse == false && counter == 11)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (A_Button.GetComponent<problem1ButtonBehavior>().responseQ11 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet11").GetComponent<Animator>().Play("Q11");

            StartCoroutine(ChangeGeometry11());
        }
        #endregion

        #region Q12
        if (buttonPressed == true && waitingForResponse == false && counter == 12)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<problem1ButtonBehavior>().waitingForResponse = true;
            }

            ChangeColor();

            //Sounds here
            if (E_Button.GetComponent<problem1ButtonBehavior>().responseQ12 == 1)
            {
                rightSound.Play();
            }

            else
            {
                wrongSound.Play();
            }

            //Animations here
            GameObject.FindGameObjectWithTag("geometrySet12").GetComponent<Animator>().Play("Q12");

            StartCoroutine(ChangeGeometry12());
        }
        #endregion
    }

    //------ COROUTINES

    public IEnumerator ChangeGeometry1()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        //Animations
        GameObject.FindGameObjectWithTag("geometrySet1").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet1").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet2").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry2()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet2").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet2").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet3").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry3()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet3").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet3").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet4").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry4()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet4").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet4").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet5").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry5()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet5").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet5").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet6").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry6()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet6").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet6").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet7").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry7()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet7").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet7").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet8").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry8()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet8").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet8").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet9").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry9()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet9").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet9").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet10").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry10()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet10").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet10").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet11").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry11()
    {
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem1ButtonBehavior>().buttonPressed = false;
        }

        GameObject.FindGameObjectWithTag("geometrySet11").GetComponent<Animator>().Play("Idle");
        buttonAnimator.Play("IdleAnimation");
        ChangeColorToOriginal();

        //Change geometry position
        GameObject.FindGameObjectWithTag("geometrySet11").transform.position = new Vector3(0, 0.035f, 4f);
        GameObject.FindGameObjectWithTag("geometrySet12").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometry12()
    {
        yield return new WaitForSeconds(timer);
        buttonAnimator.Play("IdleAnimation");
        ChangingScene();

    }

    //------ Change Scene
    public void ChangingScene()
    {
        SceneManager.LoadScene("UserPractice_secondProblem");
    }

    //------ Changing color
    public void ChangeColor()
    {
        for (int i = 0; i < correctAnswers.Length; i++)
        {
            correctAnswers[i].GetComponent<Animator>().Play("originalToGreen");
            referenceShapes[i].GetComponent<Animator>().Play("originalToGreen");
        }
    }
    public void ChangeColorToOriginal()
    {
        for (int i = 0; i < correctAnswers.Length; i++)
        {
            correctAnswers[i].GetComponent<Animator>().Play("shapeIdleAnimation");
            referenceShapes[i].GetComponent<Animator>().Play("shapeIdleAnimation");
        }
    }
}
