using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string TipoEntrenamiento;
    public int CantidadHoras;
    float PrecioPorHora;
    float PrecioTotal;
    float PrecioTotalDescuento;
    float Descuento;

    // Start is called before the first frame update
    void Start()
    {

        if ((TipoEntrenamiento != "Cardio" && TipoEntrenamiento != "Fuerza" && TipoEntrenamiento != "Recreativo")
        || CantidadHoras < 1 || CantidadHoras > 6)
        {
            Debug.Log("Error");
            return;
        }
        if (TipoEntrenamiento == "Cardio")
        {
            PrecioPorHora = 1000;
        }
        else if (TipoEntrenamiento == "Fuerza")
        {
            PrecioPorHora = 1500;
        }
        else if (TipoEntrenamiento == "Recreativo")
        {
            PrecioPorHora = 2500;
        }
        PrecioTotal = CantidadHoras * PrecioPorHora;

        if (CantidadHoras == 6)
        {
            Descuento = PrecioTotal * 0.10f;
            PrecioTotalDescuento = PrecioTotal - Descuento;
            

        }



            Debug.Log("Tipo de entrenamiento " + TipoEntrenamiento);
            Debug.Log("Horas reservadas " + CantidadHoras);
            Debug.Log("Precio sin descuento " + PrecioTotal);
            Debug.Log("Precio con descuento si aplica " + PrecioTotalDescuento);








    }
    // Update is called once per frame
    void Update()
    {

    }
}
