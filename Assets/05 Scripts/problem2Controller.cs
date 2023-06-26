using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //to export data

public class problem2Controller : MonoBehaviour
{
    private string filename = "";

    [Header("Buttons")]
    public GameObject[] buttons; //Assigned in Start

    [Header("First answer")] //Not need to assign
    public string answerQ1_1;
    public string answerQ2_1;
    public string answerQ3_1;
    public string answerQ4_1;
    public string answerQ5_1;
    public string answerQ6_1;
    public string answerQ7_1;
    public string answerQ8_1;
    public string answerQ9_1;
    public string answerQ10_1;
    public string answerQ11_1;
    public string answerQ12_1;

    [Header("Second answer")] //Not need to assign
    public string answerQ1_2;
    public string answerQ2_2;
    public string answerQ3_2;
    public string answerQ4_2;
    public string answerQ5_2;
    public string answerQ6_2;
    public string answerQ7_2;
    public string answerQ8_2;
    public string answerQ9_2;
    public string answerQ10_2;
    public string answerQ11_2;
    public string answerQ12_2;

    public float timerQ1;//Assign in update
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

    // Start is called before the first frame update
    void Start()
    {
        filename = Application.persistentDataPath + "/secondExperiment_Data.csv";

        buttons = GameObject.FindGameObjectsWithTag("button");
    }

    // Update is called once per frame
    void Update()
    {

        timerQ1 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ1 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ2 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ2 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ3 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ3 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ4 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ4 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ5 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ5 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ6 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ6 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ7 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ7 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ8 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ8 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ9 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ9 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ10 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ10 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ11 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ11 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;
        timerQ12 = buttons[0].GetComponent<problem2ButtonBehavior_v2>().timerQ12 - buttons[0].GetComponent<problem2ButtonBehavior_v2>().timer;

        for (int i = 0; i < buttons.Length; i++)
        {
            #region Q1
            if(buttons[i].GetComponent<problem2ButtonBehavior_v2>().q1_1 == 1)
            {
                answerQ1_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q1_2 == 1)
            {
                answerQ1_2 = buttons[i].name;
            }
            #endregion

            #region Q2
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q2_1 == 1)
            {
                answerQ2_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q2_2 == 1)
            {
                answerQ2_2 = buttons[i].name;
            }
            #endregion

            #region Q3
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q3_1 == 1)
            {
                answerQ3_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q3_2 == 1)
            {
                answerQ3_2 = buttons[i].name;
            }
            #endregion

            #region Q4
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q4_1 == 1)
            {
                answerQ4_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q4_2 == 1)
            {
                answerQ4_2 = buttons[i].name;
            }
            #endregion

            #region Q5
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q5_1 == 1)
            {
                answerQ5_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q5_2 == 1)
            {
                answerQ5_2 = buttons[i].name;
            }
            #endregion

            #region Q6
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q6_1 == 1)
            {
                answerQ6_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q6_2 == 1)
            {
                answerQ6_2 = buttons[i].name;
            }
            #endregion

            #region Q7
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q7_1 == 1)
            {
                answerQ7_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q7_2 == 1)
            {
                answerQ7_2 = buttons[i].name;
            }
            #endregion

            #region Q8
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q8_1 == 1)
            {
                answerQ8_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q8_2 == 1)
            {
                answerQ8_2 = buttons[i].name;
            }
            #endregion

            #region Q9
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q9_1 == 1)
            {
                answerQ9_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q9_2 == 1)
            {
                answerQ9_2 = buttons[i].name;
            }
            #endregion

            #region Q10
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q10_1 == 1)
            {
                answerQ10_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q10_2 == 1)
            {
                answerQ10_2 = buttons[i].name;
            }
            #endregion

            #region Q11
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q11_1 == 1)
            {
                answerQ11_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q11_2 == 1)
            {
                answerQ11_2 = buttons[i].name;
            }
            #endregion

            #region Q12
            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q12_1 == 1)
            {
                answerQ12_1 = buttons[i].name;
            }

            if (buttons[i].GetComponent<problem2ButtonBehavior_v2>().q12_2 == 1)
            {
                answerQ12_2 = buttons[i].name;
            }

            SaveToFile();

            #endregion
        }
    }

    // --------------- SAVE TO FILE
    public void SaveToFile()
    {
        TextWriter tw = new StreamWriter(filename, false);

        #region COLUMNS NAMES
        tw.WriteLine("First answer" + ";" + "Second answer");
        #endregion

        #region Q1
        tw.WriteLine(answerQ1_1 + ";" + answerQ1_2 + ";" + timerQ1);
        #endregion

        #region Q2
        tw.WriteLine(answerQ2_1 + ";" + answerQ2_2 + ";" + timerQ2);
        #endregion

        #region Q3
        tw.WriteLine(answerQ3_1 + ";" + answerQ3_2 + ";" + timerQ3);
        #endregion

        #region Q4
        tw.WriteLine(answerQ4_1 + ";" + answerQ4_2 + ";" + timerQ4);
        #endregion

        #region Q5
        tw.WriteLine(answerQ5_1 + ";" + answerQ5_2 + ";" + timerQ5);
        #endregion

        #region Q6
        tw.WriteLine(answerQ6_1 + ";" + answerQ6_2 + ";" + timerQ6);
        #endregion

        #region Q7
        tw.WriteLine(answerQ7_1 + ";" + answerQ7_2 + ";" + timerQ7);
        #endregion

        #region Q8
        tw.WriteLine(answerQ8_1 + ";" + answerQ8_2 + ";" + timerQ8);
        #endregion

        #region Q9
        tw.WriteLine(answerQ9_1 + ";" + answerQ9_2 + ";" + timerQ9);
        #endregion

        #region Q10
        tw.WriteLine(answerQ10_1 + ";" + answerQ10_2 + ";" + timerQ10);
        #endregion

        #region Q11
        tw.WriteLine(answerQ11_1 + ";" + answerQ11_2 + ";" + timerQ11);
        #endregion

        #region Q12
        tw.WriteLine(answerQ12_1 + ";" + answerQ12_2 + ";" + timerQ12);
        #endregion

        tw.Close();
    }

}
