using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject oggettoDaAnimare; // Trascina l'oggetto nell'Inspector in Unity.
    private Animator oggettoDaAnimareAnimator;

    private bool animazioneInCorso = false;

    public void AvviaInterrompiAnimazione()
    {
        if (oggettoDaAnimare == null)
        {
            Debug.LogError("Assicurati di trascinare un oggetto nell'Inspector.");
            return;
        }

        // Ottieni l'Animator direttamente dall'oggetto da animare se non è stato già assegnato
        if (oggettoDaAnimareAnimator == null)
        {
            oggettoDaAnimareAnimator = oggettoDaAnimare.GetComponent<Animator>();
        }

        if (oggettoDaAnimareAnimator == null)
        {
            Debug.LogError("L'oggetto da animare non ha un componente Animator.");
            return;
        }

        // Inverte lo stato dell'animazione (avvia o interrompe)
        animazioneInCorso = !animazioneInCorso;
        oggettoDaAnimareAnimator.SetBool("AvviaAnimazione", animazioneInCorso);
    }
}
