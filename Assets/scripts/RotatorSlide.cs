using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;


public class RotatorSlide : MonoBehaviour
{
    // Dichiarazione di una variabile pubblica per la rotazione in gradi
    public float rotazioneInGradi = 0f;

    // Funzione pubblica per incrementare la rotazione
    public void IncrementaRotazione(float incremento)
    {
        rotazioneInGradi += incremento;
        ApplicaRotazione();
    }

    // Funzione pubblica per diminuire la rotazione
    public void DiminuisciRotazione(float decremento)
    {
        rotazioneInGradi -= decremento;
        ApplicaRotazione();
    }

    // Funzione per applicare la rotazione
    private void ApplicaRotazione()
    {
        // Creiamo una nuova rotazione basata sul valore di rotazioneInGradi
        Quaternion nuovaRotazione = Quaternion.Euler(0f, rotazioneInGradi, 0f);

        // Impostiamo la nuova rotazione dell'oggetto
        transform.rotation = nuovaRotazione;
    }
}

