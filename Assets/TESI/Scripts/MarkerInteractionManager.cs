using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerInteractionManager : MonoBehaviour
{
    public List<ButtonTXObjScript> buttonTXList = new List<ButtonTXObjScript>();
    public List<ButtonTXObjScript> buttonOBJList = new List<ButtonTXObjScript>();

    public void UpdateButtonState(ButtonTXObjScript button)
    {
        // Attiva o disattiva entrambi i bottoni in tutte le coppie
        foreach (ButtonTXObjScript txButton in buttonTXList)
        {
            txButton.SetButtonState(button.IsButtonActive());
        }

        foreach (ButtonTXObjScript objButton in buttonOBJList)
        {
            objButton.SetButtonState(button.IsButtonActive());
        }

        // Esegui le azioni che desideri quando entrambi i bottoni sono attivati o disattivati
    }

    public void DeactivateButtons()
    {
        // Disattiva entrambi i bottoni in tutte le coppie
        foreach (ButtonTXObjScript txButton in buttonTXList)
        {
            txButton.SetButtonState(false);
        }

        foreach (ButtonTXObjScript objButton in buttonOBJList)
        {
            objButton.SetButtonState(false);
        }

        // Esegui le azioni che desideri quando entrambi i bottoni sono disattivati
    }
}