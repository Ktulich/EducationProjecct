using System;
using UnityEngine;

namespace OOP.StoveScene
{
    public class CircleSwitcher : Switcher
    {
        [SerializeField] private Transform switcher;
        [SerializeField] private float greenZoneAngleMin, greenZoneAngleMax, yellowZoneAngleMin, yellowZoneAngleMax;
        [SerializeField] private bool switchPressed;

        private Stove _stove;

        private void Start()
        {
            _stove = FindObjectOfType<Stove>();
            
            switchPressed = false;
        }

        private void Update()
        {
            if (!switchPressed)
                switcher.Rotate(0,0,-200 * Time.deltaTime);
        }
        
        public override void PressedSwitch()
        {
            if (switchPressed)
                return;
            
            switchPressed = true;
            
            Debug.Log(switcher.localEulerAngles.z);
            
            if (switcher.localEulerAngles.z > yellowZoneAngleMin && switcher.localEulerAngles.z < yellowZoneAngleMax)
            {
                if (switcher.localEulerAngles.z > greenZoneAngleMin && switcher.localEulerAngles.z < greenZoneAngleMax)
                {
                    Debug.Log("GreenZone");
                    _stove.AddLightningToStove(100);
                }
            
                else
                {
                    Debug.Log("YellowZone");
                    _stove.AddLightningToStove(50);
                }
            }
            
            else
            {
                Debug.Log("RedZone");
                _stove.RemoveLightningFromStove();
            }
        }
    }
}