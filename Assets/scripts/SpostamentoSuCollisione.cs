using UnityEngine;

public class SpostamentoSuCollisione : MonoBehaviour
{
    // L'oggetto a cui spostarsi quando c'è una collisione
    public GameObject oggettoDestinazione;

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se l'oggetto con cui hai colliso ha un certo tag
        if (collision.gameObject.CompareTag("OggettoDiCollisione"))
        {
            // Registra un messaggio di log
            Debug.Log("L'oggetto è entrato in collisione con: " + collision.gameObject.name);

            // Sposta l'oggetto corrente verso l'oggetto di destinazione
            transform.position = oggettoDestinazione.transform.position;
        }
    }
}
