using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teilbarkeit : MonoBehaviour
{
    public int zahl1;
    public string zahl;
    void Start()
    {
        zahl = zahl1.ToString();
        Debug.Log(int.Parse(zahl.Remove(2, 1)));
        
    }

    
    void Update()
    {
        
    }
}
