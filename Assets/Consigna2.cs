using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consigna2 : MonoBehaviour
{
    public string nombreAlumno;
    public int ano;
    public char especialidad;
    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno.Length == 0 || ano < 1 && ano > 5)
        {
            Debug.Log("Error");
        }
        else if (especialidad != 'T' && especialidad != 'D' && especialidad != 'G' && especialidad != 'M' && especialidad != 'H')
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }
        else if (ano < 3)
        {
            Debug.Log("Error. Aún estás en ciclo básico");
        }
        else
        {
            Debug.Log("Muchas gracias " + nombreAlumno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
