using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public static PlayerLogic Instance;

    [SerializeField]
    List<TurboEngine> _turboEngines;

    [SerializeField]
    List<TurnEngine> _leftEngine;

    [SerializeField]
    List<TurnEngine> _rightEngine;

    [SerializeField]
    Transform _centerOfMass;

    [SerializeField] 
    private Rigidbody2D _rigidBodyCOM;

    void Awake()
    {
        Instance = this;
        _rigidBodyCOM.centerOfMass = _centerOfMass.localPosition;
    }
    void Start()
    {
        ApplyAllEngines();
    }

    void Accelerate(List<BaseEngine> engines, bool isAccel)
    {
        foreach (var e in engines)
        {
            e.Accelerate(isAccel);
        }
    }

    public void Accelerate(bool isAccel)
    {
        Accelerate(_turboEngines.ConvertAll(x => (BaseEngine)x), isAccel);
    }

    public void Turn(int direction)
    {
        Accelerate(_leftEngine.ConvertAll(x => (BaseEngine)x), direction == 1);
        Accelerate(_rightEngine.ConvertAll(x => (BaseEngine)x), direction == -1);
    }

    void ApplyAllEngines()
    {
        ApplyEngine(_turboEngines.ConvertAll(x=>(BaseEngine)x));
        ApplyEngine(_leftEngine.ConvertAll(x=>(BaseEngine)x));
        ApplyEngine(_rightEngine.ConvertAll(x=>(BaseEngine)x));
    }
    void ApplyEngine(List<BaseEngine> engines)
    {
        foreach (var e in engines)
        {
            e.SetPlayer(this);
        }
    }

    void Update()
    {
        
    }
}
