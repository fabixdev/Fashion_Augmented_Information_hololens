using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class scaling : MonoBehaviour
{
    [SerializeField]
    private Transform transformToScale = null;

    public float minScale = 0.5f; // Scala minima
    public float maxScale = 2f; // Scala massima

    public void OnSliderUpdated(SliderEventData eventData)
    {
        if (transformToScale != null)
        {
            // Calcola la scala in base al valore eventData.NewValue dello slider
            float scale = Mathf.Lerp(minScale, maxScale, eventData.NewValue);

            // Applica la scala all'oggetto di gioco
            transformToScale.localScale = new Vector3(scale, scale, scale);
        }
    }
}