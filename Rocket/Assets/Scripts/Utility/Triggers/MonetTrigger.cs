using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonetTrigger : BaseTrigger
{
    [SerializeField]
    private int _cost;
    [SerializeField]
    private TextMesh _costText;

    protected override void PlayerEnter()
    {
        base.PlayerEnter();
        //
        _costText.transform.parent = null;
        _costText.text = _cost + "$";
        _costText.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
