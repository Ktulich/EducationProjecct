using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    bool _isA�cel;
    int _turnDirection;

    [SerializeField] AudioSource _engineSound;
    [SerializeField] float _engineStop = 2f;

    void Start()
    {
        UIEvents.Instance.StartAccelerateEvent += StartAcceleration;
        UIEvents.Instance.StopAccelerateEvent += FinishAcceleration;
        UIEvents.Instance.TurnEvent += Turn;
    }

    void FixedUpdate()
    {
#if UNITY_EDITOR
        /*_isA�cel = Input.GetKey(KeyCode.W);
        if (Input.GetKey(KeyCode.A))
        {
            _turnDirection = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _turnDirection = 1;
        }
        else
        {
            _turnDirection = 0;
        }*/
#endif


        PlayerLogic.Instance.Accelerate(_isA�cel);
        PlayerLogic.Instance.Turn(_turnDirection);
    }

    bool dontUsed;
    int num = 0;

    private void StartAcceleration()
    {
        _isA�cel = true;
        if (!_engineSound.isPlaying) _engineSound.Play();
        dontUsed = false;
    }

    private void FinishAcceleration()
    {
        _isA�cel = false;
        dontUsed = true;
        StartCoroutine(StopEngineSound(++num));
    }

    IEnumerator StopEngineSound(int n)
    {
        yield return new WaitForSeconds(_engineStop);
        if (n == num && dontUsed) _engineSound.Stop();
    }

    private void Turn(int direction)
    {
        _turnDirection = direction;
    }
}
