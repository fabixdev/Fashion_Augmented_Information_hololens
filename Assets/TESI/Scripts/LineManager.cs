using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Line
{
    public LineController lineController;
    public List<Transform> points = new List<Transform>();
}

public class LineManager : MonoBehaviour
{
    [SerializeField] private Transform giubbotto;
    [SerializeField] private List<Line> lines = new List<Line>();

    private bool hasStarted = false;
    private bool[] isInverted;

    private void Start()
    {
        isInverted = new bool[lines.Count];

        // Inizializza le linee
        foreach (var line in lines)
        {
            line.lineController.SetUpLine(line.points.ToArray());
        }

        hasStarted = true; // Segna che il gioco è iniziato
    }

    private void Update()
    {
        // Verifica costantemente la rotazione e aggiorna l'inversione se necessario, solo dopo l'avvio
        if (hasStarted)
        {
            CheckRotationAndInvert();
        }
    }

    private void CheckRotationAndInvert()
    {
        float currentRotationY = giubbotto.rotation.eulerAngles.y;

        for (int i = 0; i < lines.Count; i++)
        {
            if ((currentRotationY >= 90f && currentRotationY <= 270f) || (currentRotationY >= -270f && currentRotationY <= -90f))
            {
                // Rimanere invariati solo quando il valore di Y è tra -90° e 90°
                if (isInverted[i])
                {
                    // Se erano invertiti, inverti di nuovo solo se erano stati invertiti dopo l'avvio
                    Transform temp = lines[i].points[0];
                    lines[i].points[0] = lines[i].points[1];
                    lines[i].points[1] = temp;
                    isInverted[i] = false;
                }
            }
            else
            {
                // Inverti i punti solo quando superi 90° in senso orario o inferiore a -90° in senso antiorario
                if (!isInverted[i])
                {
                    Transform temp = lines[i].points[0];
                    lines[i].points[0] = lines[i].points[1];
                    lines[i].points[1] = temp;
                    isInverted[i] = true;
                }
            }

            lines[i].lineController.SetUpLine(lines[i].points.ToArray());
        }
    }
}

