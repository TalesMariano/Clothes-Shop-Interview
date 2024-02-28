using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour, IInteractable
{
    public SpriteRenderer spriteRenderer;

    public ItemVisual itemVisual;

    public void Interact()
    {
        if (CurrencyManager.Instance.SubtractValue(itemVisual.price))
        {
            SetClothing();
            OnUnselected();
            Destroy(gameObject);
        }

    }

    public void OnSelected()
    {
        CurrencyManager.Instance.ShowPrice(itemVisual.price);
    }

    public void OnUnselected()
    {
        CurrencyManager.Instance.HidePrice();
    }

    private void Start()
    {
        spriteRenderer.sprite = itemVisual.icon;
    }

    public void SetClothing()
    {
        CaracterClothing.Instance.SetClothing(itemVisual);
    }
}
