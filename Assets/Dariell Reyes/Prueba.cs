using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public Uber uber;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            uber.DarSeguimiento();
        }
    }
}
