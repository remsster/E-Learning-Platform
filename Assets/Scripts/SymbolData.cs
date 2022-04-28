using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

enum Symbols
{
    zero,
    one,
    two,
    three,
    four,
    five,
    six,
    seven,
    eight,
    nine,
    plus,
    minus,
    multiply,
    devide,
    equals
}

public class SymbolData : MonoBehaviour
{
    // return symbol data
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("The symbol is " + other.name + " and its in " + this.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("The symbol has been removed");
    }
}
