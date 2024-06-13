using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entró al Trigger");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Está dentro del Trigger!!");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Salió del Trigger");
    }
}
