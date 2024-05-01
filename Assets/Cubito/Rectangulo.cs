using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    [SerializeField] CanvasManager canvasManager;
    Animation anim;
    void Awake()
    {
        anim = GetComponent<Animation>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Cubo cubo;
        if(collision.TryGetComponent<Cubo>(out cubo) && canvasManager)
        {
            canvasManager.ShowMessageBox("Hola, " + cubo.name);
        }
        anim.Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canvasManager.HideMessageBox();
    }
}
