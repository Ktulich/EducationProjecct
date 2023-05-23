using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D _rigidbody2D;
    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Triggered");
        /*_rigidbody2D.AddForce(new Vector3(500f, 0 ,0));
        Debug.Log("Jumped");*/
    }
}
