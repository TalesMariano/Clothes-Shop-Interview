using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPriceTag : MonoBehaviour
{
    [SerializeField] private TMP_Text textField;
    [SerializeField] private CanvasGroup canvasGroup;

    [SerializeField] private RectTransform rectTransform;

    void UpdatePosition(Transform target)
    {
        rectTransform.anchoredPosition = RectTransformUtility.WorldToScreenPoint(Camera.main, target.position);
    }


}
