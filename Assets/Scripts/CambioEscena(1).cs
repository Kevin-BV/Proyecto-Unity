using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public string nombreEscena;  //variable con nombres de escenas
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nombreEscena);
    }

}

