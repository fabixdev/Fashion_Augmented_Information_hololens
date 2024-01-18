using UnityEngine;

public class CompareScompari : MonoBehaviour
{
    public GameObject oggettoDaCreare;
    private GameObject istanza;

    public void CompariScompari()
    {
        if (istanza == null)
        {
            // Se l'istanza non esiste, la creiamo
            istanza = Instantiate(oggettoDaCreare, transform.position, transform.rotation);
        }
        else
        {
            // Se l'istanza esiste già, la distruggiamo
            Destroy(istanza);
            istanza = null;
        }
    }
}
