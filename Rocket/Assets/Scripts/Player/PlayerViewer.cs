using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerViewer : MonoBehaviour
{
    [SerializeField]
    Image _fuelBar;
    [SerializeField]
    List<Image> _hpImages;

    [SerializeField] private Sprite _hasHPSprite;
    [SerializeField] private Sprite _noHPSprite;

    private void Start()
    {
        Player.Instance.onFuelLevelChanged += UpdateFuelLevel;
        Player.Instance.onHPChanged += UpdateHPCount;
    }

    void UpdateHPCount()
    {
        for (int i = 0; i < Player.Instance.HpCount(); i++)
            _hpImages[i].sprite = _hasHPSprite;
        for (int i = Player.Instance.HpCount(); i < _hpImages.Count; ++i)
            _hpImages[i].sprite = _noHPSprite;
    }

    void UpdateFuelLevel()
    {
        _fuelBar.fillAmount = Player.Instance.FuelLevel01();
    }
}
