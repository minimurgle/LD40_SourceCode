using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCrimeEvents : MonoBehaviour {

    List<string> baseCrimeEvents = new List<string>();

    public void Start()
    {

        baseCrimeEvents.Add("A robbery is in progress");//0
        baseCrimeEvents.Add("");//1
        baseCrimeEvents.Add("");//2
        baseCrimeEvents.Add("");//3
        baseCrimeEvents.Add("");//4
        baseCrimeEvents.Add("");//5
        baseCrimeEvents.Add("People are rioting in the streets");//6
    }

}
