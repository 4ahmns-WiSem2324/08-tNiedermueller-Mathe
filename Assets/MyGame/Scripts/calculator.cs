using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculator : MonoBehaviour
{

    public InputField input;
    public int integerValue;
    public int var1;
    public int var2;
    
    public int ergebnis;

    int calcmethod;

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

        integerValue = result;
    }

    public void plus()
    {
        var1 = integerValue;
        input.text = "";

        calcmethod = 1;
    }

    public void minus()
    {
        var1 = integerValue;
        input.text = "";

        calcmethod = 2;
    }

    public void multiply()
    {
        var1 = integerValue;
        input.text = "";

        calcmethod = 3;
    }

    public void divide()
    {
        var1 = integerValue;
        input.text = "";

        calcmethod = 4;
    }

    public void calculate()
    {
        var2 = integerValue;

        if (calcmethod == 1) ergebnis = var1 + var2;

        if (calcmethod == 2) ergebnis = var1 - var2;

        if (calcmethod == 3) ergebnis = var1 * var2;

        if (calcmethod == 4) ergebnis = var1 / var2;

        input.text = ergebnis.ToString();
    }
}
