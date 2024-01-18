using UnityEngine;

public class RuotaRitorna : MonoBehaviour
{
    public float velocitaRotazione = 45.0f; // Velocità di rotazione dell'oggetto (gradi al secondo)
    public float angoloMassima = 45.0f;    // Angolo massimo a cui l'oggetto ruoterà
    public float angoloMinima = -45.0f;   // Angolo minimo a cui l'oggetto ruoterà

    private bool staRuotandoAvanti = true; // Flag per determinare se l'oggetto sta ruotando in avanti o all'indietro

    void Update()
    {
        // Calcola l'angolo di rotazione in base alla velocità e al tempo
        float angoloRotazione = velocitaRotazione * Time.deltaTime;

        // Calcola la nuova angolazione Y dell'oggetto
        float nuovaAngolazioneY = transform.eulerAngles.y + (staRuotandoAvanti ? angoloRotazione : -angoloRotazione);

        // Limita la nuova angolazione all'intervallo desiderato
        nuovaAngolazioneY = Mathf.Clamp(nuovaAngolazioneY, angoloMinima, angoloMassima);

        // Imposta la nuova angolazione Y dell'oggetto
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, nuovaAngolazioneY, transform.eulerAngles.z);

        // Inverti la direzione se l'oggetto ha raggiunto l'angolo massimo o minimo
        if (nuovaAngolazioneY >= angoloMassima || nuovaAngolazioneY <= angoloMinima)
        {
            staRuotandoAvanti = !staRuotandoAvanti;
        }
    }
}
