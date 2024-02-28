using System;
using System.Collections.Generic;
using UnityEngine;


public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager Instance { get; private set; }

    [SerializeField] int startMoney = 200;

    int currentMoney;

    public Action<int> OnCurrencyChange;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        currentMoney = startMoney;
        OnCurrencyChange?.Invoke(currentMoney);
    }

    public void AddValue(int value)
    {
        currentMoney += value;
        OnCurrencyChange?.Invoke(currentMoney);
    }

    public bool SubtractValue(int value)
    {
        if (value > currentMoney)
            return false;
        else
        {
            currentMoney -= value;

            OnCurrencyChange?.Invoke(currentMoney);
            return true;
        }
    }

}
