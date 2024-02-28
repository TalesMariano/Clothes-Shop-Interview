using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPriceTag : MonoBehaviour
{
    [SerializeField] private TMP_Text textField;
    [SerializeField] private CanvasGroup canvasGroup;

    [SerializeField] private RectTransform rectTransform;

    public Transform target;

    void UpdatePosition(Transform target)
    {
        rectTransform.anchoredPosition = RectTransformUtility.WorldToScreenPoint(Camera.main, target.position);
    }

    private void Update()
    {
        UpdatePosition(target);
    }
}
