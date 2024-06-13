using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public string nombreDeEscena;
    public void CambioDeEscena()
    {
        SceneManager.LoadScene(nombreDeEscena);
    }
}
