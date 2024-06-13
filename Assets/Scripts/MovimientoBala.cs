using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public int velocidadBala;
    public float rangoX;
  
    void Update()
    {
        transform.Translate(Vector3.right * 10 * Time.deltaTime);

        if (gameObject.transform.position.x > rangoX || gameObject.transform.position.x < -rangoX)
        {
            Destroy(gameObject);
        }
    }
     

}
