using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrimZahl2 : MonoBehaviour
{
    public int rndNumber, letzteNumber;
    public TextMeshProUGUI primeText, trueText, letzteZahl;
    public bool index;

    private void Start()
    {
        RandomNumber();
    }
    public void RandomNumber()
    {
        rndNumber = Random.Range(0, 100);
        primeText.text = rndNumber.ToString();
        letzteZahl.text = "letze Zahl: " + letzteNumber;
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

    public void TrueFalse(bool a)
    {
        index = CalcIsPrime(rndNumber);

        if (a == index)
        {
            trueText.text = "True";
        }
        else
        {
            trueText.text = "False";
        }
        letzteNumber = rndNumber;
        RandomNumber();
    }
}
