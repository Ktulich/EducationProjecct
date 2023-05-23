using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDie : MonoBehaviour
{
    [SerializeField]
    private float lifetime = 0.1f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
