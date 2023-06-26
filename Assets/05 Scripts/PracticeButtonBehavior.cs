using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeButtonBehavior : MonoBehaviour
{
    public AudioSource correctAnswer;
    public AudioSource wrongAnswer;

    public GameObject ExampleShapes;
    
    public Animator canvasAnimator;

    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        if (counter == 0)
        {
            correctAnswer.Play();
            counter = 1;
            gameObject.GetComponent<Animator>().Play("originalToGrey");
            canvasAnimator.Play("TextChange");
            StartCoroutine(CanvasChange());
        }

        if (counter == 2)
        {
            wrongAnswer.Play();
            gameObject.GetComponent<Animator>().Play("originalToGrey");
            counter = 3;
            StartCoroutine(BringGeometry());
        }
    }

    public IEnumerator CanvasChange()
    {
        yield return new WaitForSeconds(2);
        counter = 2;
        gameObject.GetComponent<Animator>().Play("greyToOriginalColor");
    }

    public IEnumerator BringGeometry()
    {
        yield return new WaitForSeconds(2);
        ExampleShapes.transform.position = new Vector3(0, 0, 0);
        gameObject.transform.position = new Vector3(0, -2, 0);
    }
}
