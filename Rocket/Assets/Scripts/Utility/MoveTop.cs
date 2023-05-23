using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTop : MonoBehaviour
{
    private float _deltaTime;
    [SerializeField] private float _speed;
    void Start()
    {
        _deltaTime = Time.deltaTime;
    }
    void Update()
    {
        transform.Translate(Vector3.up * _speed * _deltaTime);
    }
}
