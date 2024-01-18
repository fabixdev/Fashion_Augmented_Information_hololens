using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestoreImmagini : MonoBehaviour
{
    public Image immagineUI;
    public Sprite[] immagini;
    private int indiceImmagineCorrente = 0;

    public Button pulsanteAvanti;
    public Button pulsanteIndietro;

    private void Start()
    {
        // Imposta l'immagine iniziale
        CambiaImmagine(indiceImmagineCorrente);

        // Assegna le funzioni di clic ai pulsanti
        pulsanteAvanti.onClick.AddListener(Avanti);
        pulsanteIndietro.onClick.AddListener(Indietro);
    }

    public void Avanti()
    {
        // Incrementa l'indice dell'immagine corrente
        indiceImmagineCorrente++;

        // Assicurati che l'indice non superi la lunghezza dell'array
        if (indiceImmagineCorrente >= immagini.Length)
        {
            indiceImmagineCorrente = 0;
        }

        // Cambia l'immagine
        CambiaImmagine(indiceImmagineCorrente);
    }

    public void Indietro()
    {
        // Decrementa l'indice dell'immagine corrente
        indiceImmagineCorrente--;

        // Assicurati che l'indice non diventi negativo
        if (indiceImmagineCorrente < 0)
        {
            indiceImmagineCorrente = immagini.Length - 1;
        }

        // Cambia l'immagine
        CambiaImmagine(indiceImmagineCorrente);
    }

    private void CambiaImmagine(int indice)
    {
        // Cambia l'immagine sulla UI utilizzando l'indice fornito
        immagineUI.sprite = immagini[indice];
    }
}
