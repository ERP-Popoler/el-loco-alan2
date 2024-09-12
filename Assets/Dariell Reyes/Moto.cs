using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moto : Uber
{
    public override void DarSeguimiento()
    {
        base.DarSeguimiento();
        print("Este es su Uber para el que quiere llegar rapido a su casa.");
    }
}
