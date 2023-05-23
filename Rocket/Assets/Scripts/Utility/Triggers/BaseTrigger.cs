using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseTrigger : MonoBehaviour
{
    
    private void OnTrigerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
            PlayerEnter();
        if (collider.tag == "Leg")
            LegEnter();
        if (collider.tag == "Platform")
            PlatformEnter();
    }

    protected virtual void PlayerEnter()
    {

    }

    protected virtual void LegEnter()
    {

    }
    protected virtual void PlatformEnter()
    {

    }

}
