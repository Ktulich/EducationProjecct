using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData _rocket;
    public static Player Instance;
    PlayerLogic _playerLogic;
    int _hp;

    [SerializeField]
    private int _maxHP;

    [SerializeField]
    private float _damageForce = 100;

    [SerializeField]
    private float _damageTime = 1f;

    [SerializeField]
    private float _maxFuelLevel;
    private float _fuelLevel;

    public event Action onFuelLevelChanged = delegate { };
    public event Action onHPChanged = delegate { };
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AddDamageForce(collision.relativeVelocity.magnitude);
    }


    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        _playerLogic = GetComponent<PlayerLogic>();
        _fuelLevel = _maxFuelLevel;
        _maxHP = _rocket.HP;
        _maxFuelLevel = _rocket.FuelLevel;
        _damageForce = _rocket.DamageForce;
        _damageTime = _rocket.DamageTime;
        _hp = _maxHP;
    }


    void Update()
    {
        CheckPosition();
    }

    void CheckPosition()
    {
        if (transform.position.y < -20)
        {
            Kill();
        }
    }
    public void Kill()
    {
        _hp = 0;
        Damage(1);
    }
    public void WasteFuel(float how)
    {
        _fuelLevel -= how;
        onFuelLevelChanged();
    }

    public void AddFuel(float how)
    {
        _fuelLevel = Mathf.Min(_fuelLevel + how, _maxFuelLevel);
        onFuelLevelChanged();
    }

    public bool HasFuel()
    {
        return _fuelLevel > 0;
    }

    public void AddDamageForce(float value)
    {
        int time = 0;

        for (int i = 1; i < 4; i++)
            if (value > _damageForce * i)
                ++time;

        if (time > 0)
            Damage(time);
    }
    public void Damage()
    {
        Damage(1);
    }

    float _lastHPDamaged = 0;
    public void Damage(int time)
    {
        if (Time.time - _lastHPDamaged < _damageTime)
        {
            return;
        }
        _lastHPDamaged = Time.time;
        _hp -= time;

        if (_hp <= 0)
        {
            LevelController.Instance.LooseLevel();
        }
    }
    public int HpCount()
    {
        return Mathf.Max(_hp, 0);
    }
    public float FuelLevel01()
    {
        return _fuelLevel / _maxFuelLevel;
    }
}
