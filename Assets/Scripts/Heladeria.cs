using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{

    // Declaracion de variables
    public string sabor;
    public int gramos;

    float precioFinal;
    float precioDescontado;
    // Start is called before the first frame update
    void Start()
    {
        if (gramos < 250 || gramos > 3000)
        {
            Debug.Log("Error");
            return;
        }

        if (sabor == "CHO")
        {
            // 2 pesos el gramo
            precioFinal = gramos * 2;
            Debug.Log("El precio final es de $" + precioFinal);
        }
        else if (sabor == "DDL")
        {
            precioFinal = gramos * 2;
            Debug.Log("El precio final es de $" + precioFinal);
        } else if (sabor == "FRU")
        {
            precioFinal = gramos * 2;
            precioDescontado = precioFinal * 0.9f;
            Debug.Log("El precio final es de $" + precioDescontado);
        }
        else
        {
            Debug.Log("Error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
