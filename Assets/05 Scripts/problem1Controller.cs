using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //to export data

public class problem1Controller : MonoBehaviour
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
        filename = Application.persistentDataPath + "/firstExperiment_Data.csv";

        buttons = GameObject.FindGameObjectsWithTag("button");
    }

    // Update is called once per frame
    void Update()
    {
        timerQ1 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ1;
        timerQ2 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ2 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ3 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ3 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ4 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ4 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ5 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ5 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ6 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ6 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ7 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ7 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ8 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ8 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ9 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ9 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ10 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ10 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ11 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ11 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;
        timerQ12 = buttons[0].GetComponent<problem1ButtonBehavior>().timerQ12 - buttons[0].GetComponent<problem1ButtonBehavior>().timer;

        for (int i = 0; i < buttons.Length; i++)
        {
            #region Q1
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ1 == 1)
            {
                answerQ1_1 = buttons[i].name;
            }
            #endregion

            #region Q2
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ2 == 1)
            {
                answerQ2_1 = buttons[i].name;
            }
            #endregion

            #region Q3
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ3 == 1)
            {
                answerQ3_1 = buttons[i].name;
            }
            #endregion

            #region Q4
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ4 == 1)
            {
                answerQ4_1 = buttons[i].name;
            }
            #endregion

            #region Q5
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ5 == 1)
            {
                answerQ5_1 = buttons[i].name;
            }
            #endregion

            #region Q6
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ6 == 1)
            {
                answerQ6_1 = buttons[i].name;
            }
            #endregion

            #region Q7
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ7 == 1)
            {
                answerQ7_1 = buttons[i].name;
            }
            #endregion

            #region Q8
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ8 == 1)
            {
                answerQ8_1 = buttons[i].name;
            }
            #endregion

            #region Q9
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ9 == 1)
            {
                answerQ9_1 = buttons[i].name;
            }
            #endregion

            #region Q10
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ10 == 1)
            {
                answerQ10_1 = buttons[i].name;
            }
            #endregion

            #region Q11
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ11 == 1)
            {
                answerQ11_1 = buttons[i].name;
            }
            #endregion

            #region Q12
            if (buttons[i].GetComponent<problem1ButtonBehavior>().responseQ12 == 1)
            {
                answerQ12_1 = buttons[i].name;
                SaveToFile();
            }
            #endregion
        }
    }

    // --------------- SAVE TO FILE
    public void SaveToFile()
    {
        TextWriter tw = new StreamWriter(filename, false);

        #region COLUMNS NAMES
        tw.WriteLine("Answer" + ";" + "Timer");
        #endregion

        #region Q1
        tw.WriteLine(answerQ1_1 + ";" + timerQ1);
        #endregion

        #region Q2
        tw.WriteLine(answerQ2_1 + ";" + timerQ2);
        #endregion

        #region Q3
        tw.WriteLine(answerQ3_1 + ";" + timerQ3);
        #endregion

        #region Q4
        tw.WriteLine(answerQ4_1 + ";" + timerQ4);
        #endregion

        #region Q5
        tw.WriteLine(answerQ5_1 + ";" + timerQ5);
        #endregion

        #region Q6
        tw.WriteLine(answerQ6_1 + ";" + timerQ6);
        #endregion

        #region Q7
        tw.WriteLine(answerQ7_1 + ";" + timerQ7);
        #endregion

        #region Q8
        tw.WriteLine(answerQ8_1 + ";" + timerQ8);
        #endregion

        #region Q9
        tw.WriteLine(answerQ9_1 + ";" + timerQ9);
        #endregion

        #region Q10
        tw.WriteLine(answerQ10_1 + ";" + timerQ10);
        #endregion

        #region Q11
        tw.WriteLine(answerQ11_1 + ";" + timerQ11);
        #endregion

        #region Q12
        tw.WriteLine(answerQ12_1 + ";" + timerQ12);
        #endregion

        tw.Close();
    }
}
