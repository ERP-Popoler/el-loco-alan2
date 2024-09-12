using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : Uber
{
   public override void DarSeguimiento()
    {
        base.DarSeguimiento();
        print("Este es el Uber Normal, por que? porque ellos lo decidieron asi.");
    }
}
