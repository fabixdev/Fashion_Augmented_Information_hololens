using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButton : MonoBehaviour
{
    public GameObject objectToShowHide; // Trascina l'oggetto dalla scena nell'Inspector

    private void Start()
    {
        // Assicurati che l'oggetto sia disattivato all'inizio
        objectToShowHide.SetActive(false);
    }

    public void ToggleObjectVisibility()
    {
        // Attiva o disattiva l'oggetto in base allo stato attuale
        objectToShowHide.SetActive(!objectToShowHide.activeSelf);
    }
}
