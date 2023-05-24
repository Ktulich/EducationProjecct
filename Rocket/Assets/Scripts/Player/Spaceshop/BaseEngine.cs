using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEngine : MonoBehaviour
{
    [SerializeField]
    protected float a_power = 1;
    protected PlayerLogic a_player;
    protected Rigidbody2D a_rigidBody;
    public bool isAccelerate;

    public void SetPlayer(PlayerLogic player)
    {
        a_player = player;
        a_rigidBody = player.GetComponent<Rigidbody2D>();
    }

    public virtual void Accelerate(bool isAccel)
    {
        if (isAccel)
            a_rigidBody.AddForceAtPosition(transform.up * a_power * Time.deltaTime, transform.position);

        isAccelerate = isAccel;
    }
}
