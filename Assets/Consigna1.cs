using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consigna1 : MonoBehaviour
{
    public float montoAConvertir;
    public char MonedaExtranjera;
    float dolares;
    float reales;
    float euros;
    // Start is called before the first frame update
    void Start()
    {
        dolares = montoAConvertir / 200;
        reales = montoAConvertir / 23;
        euros = montoAConvertir / 150;
        if (montoAConvertir <= 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }
        else
        {
            switch (MonedaExtranjera)
            {
                case 'D':
                    Debug.Log(montoAConvertir + " pesos argentinos equivalen a " + dolares + " dolares");
                    break;

                case 'R':
                    Debug.Log(montoAConvertir + " pesos argentinos equivalen a " + reales + " reales");
                    break;

                case 'E':
                    Debug.Log(montoAConvertir + " pesos argentinos equivalen a " + euros + " euros");
                    break;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
