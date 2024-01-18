using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosizioneScalaSpostato : MonoBehaviour
{
    public Transform posizioneVariabile1;
    public float scalaVariabile1 = 0.2f;

    public Transform posizioneVariabile2;
    public float scalaVariabile2 = 1f;

    void Start()
    {
        // All'inizio, posiziona il GameObject nella posizioneVariabile1 con la scalaVariabile1
        ApplicaPosizioneEscala(posizioneVariabile1.position, scalaVariabile1);
    }

    public void PosizioneOriginale()
    {
        // Cambia la posizione del GameObject a posizioneVariabile1 con scalaVariabile1
        ApplicaPosizioneEscala(posizioneVariabile1.position, scalaVariabile1);
    }

    public void PosizioneNuova()
    {
        // Cambia la posizione del GameObject a posizioneVariabile2 con scalaVariabile2
        ApplicaPosizioneEscala(posizioneVariabile2.position, scalaVariabile2);
    }

    private void ApplicaPosizioneEscala(Vector3 posizione, float scala)
    {
        // Riferimento al GameObject e applica la posizione e la scala
        transform.position = posizione;
        transform.localScale = new Vector3(scala, scala, scala);
    }
}
