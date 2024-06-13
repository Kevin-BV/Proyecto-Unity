using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeStart = 0;
    public Text textTime;

  
    void Start()
    {
        textTime.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        textTime.text = Mathf.Round(timeStart).ToString();

        if (timeStart >= 5)
        {
            SceneManager.LoadScene("03_Nivel 3");

        }
    } 
}
