using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public  static LevelController Instance;

    public event Action onFinished = delegate { };
    public event Action onLoose = delegate { };
    public event Action onCollectStar = delegate { };

    public LevelModel _levelModel;
    private int _index;

    [SerializeField]
    List<int> _moneyForStars;

    void Awake()
    {
        Instance = this;
        _levelModel.starsCount = 1;
    }

    private void Start()
    {
        //_index = GlobalLevelController.Instance.GetIndex();
    }

    public void FinishLevel()
    {
        if (_levelModel.loosed) return;
        onFinished();
        _levelModel.completed = true;
        ApplyStars();
        Money.AddMoney(EarnedMoney());
    }

    void ApplyStars()
    {
        if (LevelTimer.Instance.HasTime())
            ++_levelModel.starsCount;

        InformationAboutLevels.SetStarsCount(_index, _levelModel.starsCount);
    }

    public void CollectStar()
    {
        onCollectStar();
        _levelModel.starsCount = 2;
    }

    public int EarnedMoney()
    {
        return _moneyForStars[Mathf.Min(_levelModel.starsCount - 1, 2)];
    }
}
