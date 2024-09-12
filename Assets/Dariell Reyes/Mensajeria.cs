using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensajeria : Uber
{
   public override void DarSeguimiento()
    {
        base.DarSeguimiento();
        print("Este es su Uber para el que quiere mandame un regalo.");
    }
}
