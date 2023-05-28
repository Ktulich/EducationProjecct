using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : BaseTrigger
{
    [SerializeField] private FinishSlider m_FinishSlider = null;
    private int _counterLegOfRocket = 2;
    private int _counterLeg = 0;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag != "Leg")
            return;

        if (++_counterLeg == _counterLegOfRocket)
            m_FinishSlider.StartTimer();
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag != "Leg")
            return;

        if (_counterLeg-- == _counterLegOfRocket)
            m_FinishSlider.StopTimer();
    }
}
