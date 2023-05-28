using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMenuViewer : MonoBehaviour
{
    [SerializeField] private List<Image> _starsImages;
    [SerializeField] private Sprite _starSprite;
    [SerializeField] private Text _coinText;

    void Start()
    {
        Utility.ApplyStars(_starsImages, LevelController.Instance._levelModel.starsCount, _starSprite);
        _coinText.text = LevelController.Instance.EarnedMoney() + "$";
    }
}
