using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    private int guess = 500;
    private int min = 1;
    private int max = 1000;
    // Start is called before the first frame update
    void Start()
    {
        StartGame(); 
        
        
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500; 
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number! We will try to guess it!");
        Debug.Log("Your number has to be less than " + max + "and greater than " + min);
        Debug.Log("Now... tell me if your number is lower or higher than " + guess);
        Debug.Log("If your number is higher than our guess press up arrow");
        Debug.Log("If your number is lower than our guess press down arrow");
        Debug.Log("Press Enter if we got it right!!");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            min = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Lol you lost");
            
            StartGame();
        }
        
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is your number higher or lower than " + guess);
    }
}
