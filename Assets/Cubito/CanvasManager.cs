using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] bool disableCanvasOnAwake = true;
    Canvas canvas;
    Text text;

    private void Awake()
    {
        if (disableCanvasOnAwake)
        {
            canvas.enabled = false;
        }
        text = GetComponentInChildren<Text>();
        if(text == null)
        {
            Debug.Log("No existe Text en el Canvas");
        }
    }

    public void ShowMessageBox(string Text)
    {
        if (!text)
        {
            return;
        }
        text.text = Text;
        canvas.enabled = true;
    }

    public void HideMessageBox()
    {
        canvas.enabled = false;
    }

}
