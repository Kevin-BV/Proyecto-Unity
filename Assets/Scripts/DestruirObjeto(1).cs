using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{
    public GameObject puertaPrefab;
    public float tiempoDestruccion;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(puertaPrefab, tiempoDestruccion);
    }
}
