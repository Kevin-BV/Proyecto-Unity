using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Collider2D itemCol;
    public GameObject controladorDePuntos;
    public float puntosQueDa;
    public float tiempoDestruccion;
    public GameObject particulaPrefab;
    MovRPG player;


    //void OnTriggerEnter2D(Collider2D collision)
    // {
    //   controladorDePuntos.GetComponent<ControladorPuntaje>().puntos += puntosQueDa;
    //    Instantiate(particulaPrefab, gameObject.transform.position, gameObject.transform.rotation);

    //Destroy(gameObject, tiempoDestruccion);
    // }


    //private void OnTriggerEnter2D(Collider2D collision)
    // void Update()
    //{
    //  if(player )
    //  controladorDePuntos.GetComponent<ControladorPuntaje>().puntos += puntosQueDa;
    // Instantiate(particulaPrefab, gameObject.transform.position, gameObject.transform.rotation);
    // Destroy(gameObject, tiempoDestruccion);


    //}
}
