using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIEvents : MonoBehaviour
{
    public static UIEvents Instance;

    public event Action StartAccelerateEvent = delegate {};
    public event Action StopAccelerateEvent = delegate {};
    public delegate void TurnDelegate(int dir);
    public event TurnDelegate TurnEvent = delegate { };

    private void Awake()
    {
        Instance = this;
    }

    public void StartAcceleration()
    {
        StartAccelerateEvent?.Invoke();
    }

    public void FinishAcceleration()
    {
        StopAccelerateEvent?.Invoke();
    }

    public void Turn(int direction)
    {
        TurnEvent(direction);
    }
}
