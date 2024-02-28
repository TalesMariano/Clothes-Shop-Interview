using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public ItemVisual itemVisual;

    private void Start()
    {
        spriteRenderer.sprite = itemVisual.icon;
    }
}
