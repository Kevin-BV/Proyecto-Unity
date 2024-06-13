using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPuntaje : MonoBehaviour
{
    public float puntos;
    public Text textoPuntos;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        textoPuntos.text = "Mis Puntos: " + puntos.ToString();
    }
}
