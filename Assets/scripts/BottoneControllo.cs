using UnityEngine;
using UnityEngine.UI;

public class BottoneControllo : MonoBehaviour
{
    public CompareScompari compareScompariScript;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        compareScompariScript.CompariScompari();
    }
}
