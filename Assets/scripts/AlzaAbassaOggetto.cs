using UnityEngine;

public class AlzaAbassaOggetto : MonoBehaviour
{
    public float velocitaMovimento = 1.0f; // Velocità di movimento dell'oggetto
    public float altezzaMassima = 5.0f;    // Altezza massima a cui l'oggetto si alzerà
    public float altezzaMinima = 0.0f;    // Altezza minima a cui l'oggetto si abbasserà

    private bool staSalendo = true; // Flag per determinare se l'oggetto sta salendo o scendendo

    void Update()
    {
        // Calcola il passo di movimento in base alla velocità e al tempo
        float passo = velocitaMovimento * Time.deltaTime;

        // Calcola la nuova posizione Y dell'oggetto
        float nuovaPosizioneY = transform.position.y + (staSalendo ? passo : -passo);

        // Limita la nuova posizione all'intervallo desiderato
        nuovaPosizioneY = Mathf.Clamp(nuovaPosizioneY, altezzaMinima, altezzaMassima);

        // Imposta la posizione Y dell'oggetto
        transform.position = new Vector3(transform.position.x, nuovaPosizioneY, transform.position.z);

        // Inverti la direzione se l'oggetto ha raggiunto l'altezza massima o minima
        if (nuovaPosizioneY >= altezzaMassima || nuovaPosizioneY <= altezzaMinima)
        {
            staSalendo = !staSalendo;
        }
    }
}
