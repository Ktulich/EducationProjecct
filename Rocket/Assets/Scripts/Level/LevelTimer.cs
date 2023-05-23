using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    public static LevelTimer Instance;

    [SerializeField] private float _maxTime;
    private float _currentTime;

    [SerializeField] private Image _timer;
    [SerializeField] private Image _arrow;
    [SerializeField] private Sprite _timerWaste;
    [SerializeField] private Sprite _arrowWaste;

    private bool changed;

    private void Awake()
    {
        Instance = this;
        _currentTime = _maxTime;
    }

    private void Start()
    {
        LevelController.Instance.onFinished += Stop;
    }

    public bool HasTime()
    {
        return _currentTime > 0;
    }

    void Update()
    {
        if (!changed)
        {
            _currentTime -= Time.deltaTime;
            UpdateView();
        }
    }

    void UpdateView()
    {
        if (HasTime())
        {
            var rot = _arrow.transform.eulerAngles;
            rot.z = TimeAge10() * 360;
            _arrow.transform.eulerAngles = rot;
        }
        else
        {
            Stop();
            var rot = _arrow.transform.eulerAngles; rot.z = 0;
            _arrow.transform.eulerAngles = rot;
            _timer.sprite = _timerWaste;
            _arrow.sprite = _arrowWaste;
        }
    }

    float TimeAge10()
    {
        return _currentTime / _maxTime;
    }

    public void Stop()
    {
        changed = true;
    }
}
