using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private int _counterLegOfRocket = 2;
    private int _counterLeg = 2;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag != "Leg")
        {
            return;
        }

        if (++_counterLeg == _counterLegOfRocket)
        {
            // Start Slider
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag != "Leg")
        {
            return;
        }

        if (_counterLeg-- == _counterLegOfRocket)
        {
            // Stop and Respawn Slider
        }
    }
}
