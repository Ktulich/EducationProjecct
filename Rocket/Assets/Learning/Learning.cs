using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    [SerializeField] private List<GameObject> _slides;
    int _currentSlide = 0;

    private void Start()
    {
        foreach (var slide in _slides)
            slide.SetActive(false);

        _slides[_currentSlide].SetActive(true);
    }

    public void NextSlide()
    {
        HideCurrent();
        ShowNext();
    }

    private void HideCurrent()
    {
        if (_currentSlide < _slides.Count)
        {
            Time.timeScale = 1;
            _slides[_currentSlide++].SetActive(false);
        }
    }

    private void ShowNext()
    {
        if (_currentSlide < _slides.Count)
        {
            Time.timeScale = 0;
            _slides[_currentSlide].SetActive(true);
        }
    }

    public void NextSlideWithDelay(float delay)
    {
        StartCoroutine(Next(delay));
    }

    IEnumerator Next(float delay)
    {
        HideCurrent();
        yield return new WaitForSeconds(delay);
        ShowNext();
    }
}
