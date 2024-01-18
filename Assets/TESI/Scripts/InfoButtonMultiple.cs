using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButtonMultiple : MonoBehaviour
{
    public List<GameObject> objectsToShowHide; // Trascina gli oggetti dalla scena nell'Inspector

    private void Start()
    {
        // Assicurati che gli oggetti siano disattivati all'inizio
        foreach (GameObject obj in objectsToShowHide)
        {
            obj.SetActive(false);
        }
    }

    public void ToggleObjectsVisibility()
    {
        // Attiva o disattiva gli oggetti in base allo stato attuale
        foreach (GameObject obj in objectsToShowHide)
        {
            obj.SetActive(!obj.activeSelf);
        }
    }
}

