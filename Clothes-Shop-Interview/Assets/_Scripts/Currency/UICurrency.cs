using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICurrency : MonoBehaviour
{
    [SerializeField] private TMP_Text textField;

    private void OnEnable()
    {
        CurrencyManager.Instance.OnCurrencyChange += UpdateCurrency;
    }

    private void OnDisable()
    {
        CurrencyManager.Instance.OnCurrencyChange -= UpdateCurrency;
    }

    void UpdateCurrency(int newCurrency)
    {
        textField.text = "$ " + newCurrency + ".00";
    }
}
