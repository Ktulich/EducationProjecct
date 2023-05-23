using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurboEngine : BaseEngine
{
    [SerializeField] private float waste;

    public override void Accelerate(bool isAccel)
    {
        if (Player.Instance.HasFuel() && isAccel)
        {
            base.Accelerate(isAccel);
            Player.Instance.WasteFuel(waste);
        }
        else
            base.Accelerate(false);
    }
}
