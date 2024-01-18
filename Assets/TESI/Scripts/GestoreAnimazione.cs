using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestoreAnimazione : MonoBehaviour
{
    public GameObject capo2; // Trascina l'oggetto "Capo2" nell'Inspector in Unity.
    public Animator capo2Animator; // Trascina l'Animator del tuo oggetto "Capo2" nell'Inspector in Unity.

    private bool animazioneInCorso = false;

    public void AvviaInterrompiAnimazione()
    {
        // Ottieni l'Animator direttamente dall'oggetto "Capo2" se non è stato già assegnato
        if (capo2Animator == null)
        {
            capo2Animator = capo2.GetComponent<Animator>();
        }

        // Inverte lo stato dell'animazione (avvia o interrompe)
        animazioneInCorso = !animazioneInCorso;
        capo2Animator.SetBool("AvviaAnimazione", animazioneInCorso); // Assicurati che il nome del parametro nel tuo Animator sia "AvviaAnimazione"
    }
}
