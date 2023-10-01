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

        integer_Value_we_Want = result;

        isPrime = CalcIsPrime(integer_Value_we_Want);

        if (isPrime) text.text = "Ist eine Primzahl";


        else if (!isPrime) text.text = "Ist keine Primzahl";
    }

    public bool CalcIsPrime(int number)
    {

        if (number == 1) return false;
        if (number == 2) return true;

        if (number % 2 == 0) return false; // Even number     

        for (int i = 2; i < number; i++)
        { // Advance from two to include correct calculation for '4'
            if (number % i == 0) return false;
        }

        return true;

    }
}
