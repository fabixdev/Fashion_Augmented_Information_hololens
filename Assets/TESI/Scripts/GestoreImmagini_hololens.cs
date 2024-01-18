using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestoreImmagini_hololens : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] immagini;
    private int indiceImmagineCorrente = 0;

    private void Start()
    {
        // Imposta l'immagine iniziale
        CambiaImmagine(indiceImmagineCorrente);
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
        // Cambia lo sprite del componente SpriteRenderer utilizzando l'indice fornito
        spriteRenderer.sprite = immagini[indice];
    }
}

