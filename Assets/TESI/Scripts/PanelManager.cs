using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject pannelloDaMostrare;

    public void MostraPannello()
    {
        // Mostra il pannello da mostrare
        pannelloDaMostrare.SetActive(true);
    }

    public void NascondiPannello()
    {
        // Nascondi il pannello da mostrare
        pannelloDaMostrare.SetActive(false);
    }
}
