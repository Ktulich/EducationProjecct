using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Default : MonoBehaviour
{
    delegate int Operation(int x, int y);
    void Start()
    {
        Math sum = new Math();
        Operation opSum = sum.Sum;
        int result = opSum(5, 6);
        Debug.Log(result);
    }
}
