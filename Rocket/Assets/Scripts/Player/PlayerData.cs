using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player", fileName = "Default")]

public class PlayerData : ScriptableObject
{
    public int FuelLevel;
    public int HP;
    public int DamageForce;
    public int DamageTime;

    public int PowerTurbo;
    public int PowerTurn;
}