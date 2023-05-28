using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonetTrigger : BaseTrigger
{
    [SerializeField]
    private int _cost;
    [SerializeField]
    private TextMesh _costText;

    protected override void PlayerEnter()
    {
        base.PlayerEnter();
        Money.AddMoney(_cost);
        _costText.transform.parent = null;
        _costText.text = _cost + "$";
        _costText.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
