using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Money
{
    private static string MONEY = "Money";
    private static string CRYSTALS = "CRYSTALS";

    public static event Action onMoneyChanged = delegate {};

    public static bool CanBuy(int cnt)
    {
        return MoneyLeft() >= cnt;
    }

    public static int MoneyLeft()
    {
        return PlayerPrefs.GetInt(MONEY);
    }

    public static void AddMoney(int cnt)
    {
        WasteMoney(-cnt);
    }

    public static void WasteMoney(int cnt)
    {
        PlayerPrefs.SetInt(MONEY, MoneyLeft() - cnt);
        onMoneyChanged();
    }

    public static int CrystalsLeft()
    {
        return PlayerPrefs.GetInt(CRYSTALS);
    }
}
