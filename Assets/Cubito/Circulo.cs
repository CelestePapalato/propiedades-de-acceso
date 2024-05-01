using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    [SerializeField]
    CanvasManager canvasManager;
    Animation anim;

    [SerializeField]
    string nombreAnimacion1;
    [SerializeField]
    string nombreAnimacion2;

    void Start()
    {
        anim = GetComponent<Animation>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Cubo cubito;
        if(!collision.TryGetComponent<Cubo>(out cubito))
        {
            return;
        }
        if(cubito.Nombre == "Circulo")
        {
            canvasManager.ShowMessageBox("Me gusta tu nombre");
            anim.Play(nombreAnimacion2);
        }
        else
        {
            canvasManager.ShowMessageBox("No me gusta tu nombre. ¡Ahora serás 'Circulo'!");
            cubito.Nombre = "Circulo";
            anim.Play(nombreAnimacion1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canvasManager.HideMessageBox();
        anim.Play();
    }
}
