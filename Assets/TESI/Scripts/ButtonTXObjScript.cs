using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTXObjScript : MonoBehaviour
{
    private bool isButtonActive = false;
    public Image buttonTXImage;
    public Image buttonOBJImage;
    public Sprite selectedSprite;
    public Sprite originalSprite;

    public void ToggleButtonState()
    {
        isButtonActive = !isButtonActive;

        buttonTXImage.sprite = isButtonActive ? selectedSprite : originalSprite;
        buttonOBJImage.sprite = isButtonActive ? selectedSprite : originalSprite;
    }

    public void SetButtonState(bool active)
    {
        isButtonActive = active;

        buttonTXImage.sprite = isButtonActive ? selectedSprite : originalSprite;
        buttonOBJImage.sprite = isButtonActive ? selectedSprite : originalSprite;
    }

    public bool IsButtonActive()
    {
        return isButtonActive;
    }
}
