using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UICurrency : MonoBehaviour
{
    [SerializeField] private TMP_Text textField;

    [Space]
    [SerializeField] private TMP_Text priceTagText;
    [SerializeField] private CanvasGroup priceTagCanvasGroup;

    private void OnEnable()
    {
        CurrencyManager.Instance.OnCurrencyChange += UpdateCurrency;
        CurrencyManager.Instance.OnShowPrice += ShowPrice;
        CurrencyManager.Instance.OnHidePrice += HidePrice;
    }

    private void OnDisable()
    {
        CurrencyManager.Instance.OnCurrencyChange -= UpdateCurrency;
        CurrencyManager.Instance.OnShowPrice -= ShowPrice;
        CurrencyManager.Instance.OnHidePrice -= HidePrice;
    }

    void UpdateCurrency(int newCurrency)
    {
        textField.text = "$ " + newCurrency + ".00";
    }

    void ShowPrice(int price)
    {
        priceTagCanvasGroup.alpha = 1;
        priceTagText.text = "$ " + price + ".00";
    }

    void HidePrice()
    {
        priceTagCanvasGroup.alpha = 0;
    }
}
