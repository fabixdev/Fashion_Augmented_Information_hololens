using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject capo1; // Trascina il GameObject "capo1" qui
    public Material Material1; // Trascina il materiale giallo qui
    public Material Material2;  // Trascina il materiale verde qui
    public Material Material3;  // Trascina il materiale verde qui

    public void ChangeToMaterial1()
    {
        Renderer capoRenderer = capo1.GetComponent<Renderer>();
        capoRenderer.material = Material1;
    }

    public void ChangeToMaterial2()
    {
        Renderer capoRenderer = capo1.GetComponent<Renderer>();
        capoRenderer.material = Material2;
    }

    public void ChangeToMaterial3()
    {
        Renderer capoRenderer = capo1.GetComponent<Renderer>();
        capoRenderer.material = Material3;
    }

}