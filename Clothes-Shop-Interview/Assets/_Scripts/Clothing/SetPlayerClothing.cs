using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerClothing : MonoBehaviour
{
    [SerializeField] private ItemVisual itemVisual;

    public void SetClothing()
    {
        CaracterClothing.Instance.SetClothing(itemVisual);
    }
}
