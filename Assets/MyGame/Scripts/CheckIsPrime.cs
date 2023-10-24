using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckIsPrime : MonoBehaviour
{

    [SerializeField] bool isPrime;
    public InputField input;
    public int integer_Value_we_Want;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void weitergeben()
    {
        int.TryParse(input.text, out int result);
        try
        {
            int intValue = int.Parse(input.text);
            Debug.Log(input + " ist ein gültiger Integer. Wert: " + intValue);
            integer_Value_we_Want = result;
            isPrime = CalcIsPrime(integer_Value_we_Want);

            if (isPrime) text.text = "Ist eine Primzahl";


            else if (!isPrime) text.text = "Ist keine Primzahl";
        }
        catch (FormatException)
        {
            Debug.LogError(input + " ist kein gültiger Integer.");
            text.text = "ungültige Eingabe";
        }
        
        

        
    }

    public bool CalcIsPrime(int number)
    {

        if (number == 1) return false;
        if (number == 2) return true;

        if (number % 2 == 0) return false;   

        for (int i = 2; i < number; i++)
        { 
            if (number % i == 0) return false;
        }

        return true;

    }
}
