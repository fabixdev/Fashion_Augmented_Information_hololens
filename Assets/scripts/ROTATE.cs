using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using UnityEngine.UI;

   public class ROTATE : MonoBehaviour
{
    [SerializeField]
    private Transform transformToRotate = null;

    public void OnSliderUpdated(SliderEventData eventData)
    {
        if (transformToRotate != null)
        {
            // Calcola l'angolo di rotazione in base al valore eventData.NewValue dello slider
            float rotationAngle = 360f * eventData.NewValue;
            
            // Applica la rotazione sull'asse Y all'oggetto di destinazione
            transformToRotate.rotation = Quaternion.Euler(0f, rotationAngle, 0f);
        }
    }
}