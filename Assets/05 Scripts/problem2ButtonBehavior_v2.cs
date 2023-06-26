using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class problem2ButtonBehavior_v2 : MonoBehaviour
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

    public int q2_1;
    public int q2_2;

    public int q3_1;
    public int q3_2;

    public int q4_1;
    public int q4_2;

    public int q5_1;
    public int q5_2;

    public int q6_1;
    public int q6_2;

    public int q7_1;
    public int q7_2;

    public int q8_1;
    public int q8_2;

    public int q9_1;
    public int q9_2;

    public int q10_1;
    public int q10_2;

    public int q11_1;
    public int q11_2;

    public int q12_1;
    public int q12_2;
    #endregion

    [Header("Timers")]
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

        #region user response set to 0
        q1_1 = 0;
        q1_2 = 0;

        q2_1 = 0;
        q2_2 = 0;

        q3_1 = 0;
        q3_2 = 0;

        q4_1 = 0;
        q4_2 = 0;

        q5_1 = 0;
        q5_2 = 0;

        q6_1 = 0;
        q6_2 = 0;

        q7_1 = 0;
        q7_2 = 0;

        q8_1 = 0;
        q8_2 = 0;

        q9_1 = 0;
        q9_2 = 0;

        q10_1 = 0;
        q10_2 = 0;

        q11_1 = 0;
        q11_2 = 0;

        q12_1 = 0;
        q12_2 = 0;
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

        firstButtonPressed = false;
        alreadyUsedButton = false;
        responsesRecorded = false;
    }

    // Update is called once per frame
    void Update()
    {
        #region timers update
        if (currentQuestion == 1)
        {
            timerQ1 += Time.deltaTime;
        }

        if (currentQuestion == 2)
        {
            timerQ2 += Time.deltaTime;
        }

        if (currentQuestion == 3)
        {
            timerQ3 += Time.deltaTime;
        }

        if (currentQuestion == 4)
        {
            timerQ4 += Time.deltaTime;
        }

        if (currentQuestion == 5)
        {
            timerQ5 += Time.deltaTime;
        }

        if (currentQuestion == 6)
        {
            timerQ6 += Time.deltaTime;
        }

        if (currentQuestion == 7)
        {
            timerQ7 += Time.deltaTime;
        }

        if (currentQuestion == 8)
        {
            timerQ8 += Time.deltaTime;
        }

        if (currentQuestion == 9)
        {
            timerQ9 += Time.deltaTime;
        }

        if (currentQuestion == 10)
        {
            timerQ10 += Time.deltaTime;
        }

        if (currentQuestion == 11)
        {
            timerQ11 += Time.deltaTime;
        }

        if (currentQuestion == 12)
        {
            timerQ12 += Time.deltaTime;
        }
        #endregion
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
                buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = true;
            }

            alreadyUsedButton = true;

            #region Q1
            if (currentQuestion == 1)
            {
                q1_1 = 1;
            }
            #endregion

            #region Q2
            if (currentQuestion == 2)
            {
                q2_1 = 1;
            }
            #endregion

            #region Q3
            if (currentQuestion == 3)
            {
                q3_1 = 1;
            }
            #endregion

            #region Q4
            if (currentQuestion == 4)
            {
                q4_1 = 1;
            }
            #endregion

            #region Q5
            if (currentQuestion == 5)
            {
                q5_1 = 1;
            }
            #endregion

            #region Q6
            if (currentQuestion == 6)
            {
                q6_1 = 1;
            }
            #endregion

            #region Q7
            if (currentQuestion == 7)
            {
                q7_1 = 1;
            }
            #endregion

            #region Q8
            if (currentQuestion == 8)
            {
                q8_1 = 1;
            }
            #endregion

            #region Q9
            if (currentQuestion == 9)
            {
                q9_1 = 1;
            }
            #endregion

            #region Q10
            if (currentQuestion == 10)
            {
                q10_1 = 1;
            }
            #endregion

            #region Q11
            if (currentQuestion == 11)
            {
                q11_1 = 1;
            }
            #endregion

            #region Q12
            if (currentQuestion == 12)
            {
                q12_1 = 1;
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
                buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = true;
            }

            #region Q1
            if (currentQuestion == 1)
            {
                q1_2= 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (C_Button.GetComponent<problem2ButtonBehavior_v2>().q1_1 == 1 && A_Button.GetComponent<problem2ButtonBehavior_v2>().q1_2 == 1)
                {
                    rightSound.Play();
                }

                else if (A_Button.GetComponent<problem2ButtonBehavior_v2>().q1_1 == 1 && C_Button.GetComponent<problem2ButtonBehavior_v2>().q1_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet1").GetComponent<Animator>().Play("problem2_Q1");

                //change geometry
                StartCoroutine(ChangeGeometrySet1());
            }
            #endregion

            #region Q2
            if (currentQuestion == 2)
            {
                q2_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (D_Button.GetComponent<problem2ButtonBehavior_v2>().q2_1 == 1 && B_Button.GetComponent<problem2ButtonBehavior_v2>().q2_2 == 1)
                {
                    rightSound.Play();
                }

                else if (B_Button.GetComponent<problem2ButtonBehavior_v2>().q2_1 == 1 && D_Button.GetComponent<problem2ButtonBehavior_v2>().q2_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet2").GetComponent<Animator>().Play("problem2_Q2");

                //change geometry
                StartCoroutine(ChangeGeometrySet2());
            }
            #endregion

            #region Q3
            if (currentQuestion == 3)
            {
                q3_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (D_Button.GetComponent<problem2ButtonBehavior_v2>().q3_1 == 1 && A_Button.GetComponent<problem2ButtonBehavior_v2>().q3_2 == 1)
                {
                    rightSound.Play();
                }

                else if (A_Button.GetComponent<problem2ButtonBehavior_v2>().q3_1 == 1 && D_Button.GetComponent<problem2ButtonBehavior_v2>().q3_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet3").GetComponent<Animator>().Play("problem2_Q3");

                //change geometry
                StartCoroutine(ChangeGeometrySet3());
            }
            #endregion

            #region Q4
            if (currentQuestion == 4)
            {
                q4_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (B_Button.GetComponent<problem2ButtonBehavior_v2>().q4_1 == 1 && C_Button.GetComponent<problem2ButtonBehavior_v2>().q4_2 == 1)
                {
                    rightSound.Play();
                }

                else if (C_Button.GetComponent<problem2ButtonBehavior_v2>().q4_1 == 1 && B_Button.GetComponent<problem2ButtonBehavior_v2>().q4_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet4").GetComponent<Animator>().Play("problem2_Q4");

                //change geometry
                StartCoroutine(ChangeGeometrySet4());
            }
            #endregion

            #region Q5
            if (currentQuestion == 5)
            {
                q5_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (B_Button.GetComponent<problem2ButtonBehavior_v2>().q5_1 == 1 && D_Button.GetComponent<problem2ButtonBehavior_v2>().q5_2 == 1)
                {
                    rightSound.Play();
                }

                else if (D_Button.GetComponent<problem2ButtonBehavior_v2>().q5_1 == 1 && B_Button.GetComponent<problem2ButtonBehavior_v2>().q5_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet5").GetComponent<Animator>().Play("problem2_Q5");

                //change geometry
                StartCoroutine(ChangeGeometrySet5());
            }
            #endregion

            #region Q6
            if (currentQuestion == 6)
            {
                q6_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (A_Button.GetComponent<problem2ButtonBehavior_v2>().q6_1 == 1 && D_Button.GetComponent<problem2ButtonBehavior_v2>().q6_2 == 1)
                {
                    rightSound.Play();
                }

                else if (D_Button.GetComponent<problem2ButtonBehavior_v2>().q6_1 == 1 && A_Button.GetComponent<problem2ButtonBehavior_v2>().q6_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet6").GetComponent<Animator>().Play("problem2_Q6");

                //change geometry
                StartCoroutine(ChangeGeometrySet6());
            }
            #endregion

            #region Q7
            if (currentQuestion == 7)
            {
                q7_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (B_Button.GetComponent<problem2ButtonBehavior_v2>().q7_1 == 1 && D_Button.GetComponent<problem2ButtonBehavior_v2>().q7_2 == 1)
                {
                    rightSound.Play();
                }

                else if (D_Button.GetComponent<problem2ButtonBehavior_v2>().q7_1 == 1 && B_Button.GetComponent<problem2ButtonBehavior_v2>().q7_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet7").GetComponent<Animator>().Play("problem2_Q7");

                //change geometry
                StartCoroutine(ChangeGeometrySet7());
            }
            #endregion

            #region Q8
            if (currentQuestion == 8)
            {
                q8_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (B_Button.GetComponent<problem2ButtonBehavior_v2>().q8_1 == 1 && D_Button.GetComponent<problem2ButtonBehavior_v2>().q8_2 == 1)
                {
                    rightSound.Play();
                }

                else if (D_Button.GetComponent<problem2ButtonBehavior_v2>().q8_1 == 1 && B_Button.GetComponent<problem2ButtonBehavior_v2>().q8_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet8").GetComponent<Animator>().Play("problem2_Q8");

                //change geometry
                StartCoroutine(ChangeGeometrySet8());
            }
            #endregion

            #region Q9
            if (currentQuestion == 9)
            {
                q9_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (B_Button.GetComponent<problem2ButtonBehavior_v2>().q9_1 == 1 && D_Button.GetComponent<problem2ButtonBehavior_v2>().q9_2 == 1)
                {
                    rightSound.Play();
                }

                else if (D_Button.GetComponent<problem2ButtonBehavior_v2>().q9_1 == 1 && B_Button.GetComponent<problem2ButtonBehavior_v2>().q9_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet9").GetComponent<Animator>().Play("problem2_Q9");

                //change geometry
                StartCoroutine(ChangeGeometrySet9());
            }
            #endregion

            #region Q10
            if (currentQuestion == 10)
            {
                q10_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (B_Button.GetComponent<problem2ButtonBehavior_v2>().q10_1 == 1 && D_Button.GetComponent<problem2ButtonBehavior_v2>().q10_2 == 1)
                {
                    rightSound.Play();
                }

                else if (D_Button.GetComponent<problem2ButtonBehavior_v2>().q10_1 == 1 && B_Button.GetComponent<problem2ButtonBehavior_v2>().q10_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet10").GetComponent<Animator>().Play("problem2_Q10");

                //change geometry
                StartCoroutine(ChangeGeometrySet10());
            }
            #endregion

            #region Q11
            if (currentQuestion == 11)
            {
                q11_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (B_Button.GetComponent<problem2ButtonBehavior_v2>().q11_1 == 1 && C_Button.GetComponent<problem2ButtonBehavior_v2>().q11_2 == 1)
                {
                    rightSound.Play();
                }

                else if (C_Button.GetComponent<problem2ButtonBehavior_v2>().q11_1 == 1 && B_Button.GetComponent<problem2ButtonBehavior_v2>().q11_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet11").GetComponent<Animator>().Play("problem2_Q11");

                //change geometry
                StartCoroutine(ChangeGeometrySet11());
            }
            #endregion

            #region Q12
            if (currentQuestion == 12)
            {
                q12_2 = 1;

                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = true;
                }

                //play sounds for right or wrong answer
                #region Sounds
                if (A_Button.GetComponent<problem2ButtonBehavior_v2>().q12_1 == 1 && D_Button.GetComponent<problem2ButtonBehavior_v2>().q12_2 == 1)
                {
                    rightSound.Play();
                }

                else if (D_Button.GetComponent<problem2ButtonBehavior_v2>().q12_1 == 1 && A_Button.GetComponent<problem2ButtonBehavior_v2>().q12_2 == 1)
                {
                    rightSound.Play();
                }

                else
                {
                    wrongSound.Play();
                }
                #endregion

                //play animation for shapes
                GameObject.FindGameObjectWithTag("geometrySet12").GetComponent<Animator>().Play("problem2_Q12");

                //change geometry
                StartCoroutine(ChangeGeometrySet12());
            }
            #endregion


        }
    }

    //-------------- COROUTINES
    public IEnumerator ChangeGeometrySet1()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 2;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet1").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet2").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet2()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 3;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet2").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet3").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet3()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 4;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet3").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet4").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet4()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 5;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet4").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet5").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet5()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 6;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet5").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet6").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet6()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 7;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet6").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet7").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet7()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 8;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet7").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet8").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet8()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 9;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet8").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet9").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet9()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 10;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet9").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet10").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet10()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 11;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet10").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet11").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet11()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().firstButtonPressed = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().alreadyUsedButton = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().responsesRecorded = false;
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 12;
            buttons[i].GetComponent<Animator>().Play("IdleAnimation");
        }

        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet11").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("geometrySet12").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public IEnumerator ChangeGeometrySet12()
    {
        yield return new WaitForSeconds(timer);

        //Reset bools
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<problem2ButtonBehavior_v2>().currentQuestion = 13;
        }
        //Changing geometry
        GameObject.FindGameObjectWithTag("geometrySet12").transform.position = new Vector3(0, 0.035f, 4);
        GameObject.FindGameObjectWithTag("Finish").transform.position = new Vector3(0, 0.035f, 0.303f);
    }

    public void ButtonColorAnimation()
    {
        if (responsesRecorded == false)
        {
            buttonAnimator.Play("originalToGrey");
        }
    }
}
