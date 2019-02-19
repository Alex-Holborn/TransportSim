using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGroup : MonoBehaviour
{
    [SerializeField] Button[] buttons;

    public Button activeButton { get; private set; }

    public void ButtonPressed(Button b)
    {
        if (activeButton == null)
        {
            b.GetComponent<Image>().color = Color.yellow;
            activeButton = b;
        }
        else
        {
            if (activeButton == b) return;
            else
            {
                activeButton.GetComponent<Image>().color = Color.white;
                b.GetComponent<Image>().color = Color.yellow;
                activeButton = b;
            }
        }
    }
}
