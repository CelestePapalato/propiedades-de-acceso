using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tienda
{
    private string _nombre;
    public string Nombre { get => _nombre; private set => _nombre = value; }
    private float _precio;
    public float Precio { get => _precio; private set => _precio = value; }

    public Tienda(string nuevoNombre, float nuevoPrecio)
    {
        Nombre = nuevoNombre;
        Precio = nuevoPrecio;
    }
}

public class ContenedorTienda : MonoBehaviour
{
    List<Tienda> tiendas = new List<Tienda>();
    void Start()
    {
        tiendas.Add(new Tienda("Espada de hierro", 1.5f));
        tiendas.Add(new Tienda("Escudo de madera", 0.5f));
        tiendas.Add(new Tienda("Pistola:Pew-Pew", 9999));

        foreach(Tienda tienda in tiendas)
        {
            Debug.Log(tienda.Nombre + " $" + tienda.Precio.ToString("0.00"));
        }
    }
}
