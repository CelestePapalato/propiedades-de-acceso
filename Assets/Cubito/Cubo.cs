using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float velocidad;
    [SerializeField]
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!IsStringEmpty(value))
            {
                nombre = value;
            }
        }
    }

    void FixedUpdate()
    {
        Movimiento();
    }

    void Movimiento()
    {
        Vector2 horizontal = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.Translate(horizontal * velocidad * Time.deltaTime);
    }

    bool IsStringEmpty(string text)
    {
        foreach(char character in text)
        {
            if(character != ' ' && character != '\n')
            {
                return false;
            }
        }
        return true;
    }
}
