using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTop : MonoBehaviour
{
    [SerializeField] private float _speed;
    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
    }
}
