using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirAplicacion : MonoBehaviour
{
    public void SalirdeAplicacion()
    {
        Application.Quit();
        Debug.Log("Cerrando aplicación");
    }
        
}
