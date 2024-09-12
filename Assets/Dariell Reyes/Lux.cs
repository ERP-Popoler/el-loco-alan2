using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lux : Uber
{
    public override void DarSeguimiento()
    {
        base.DarSeguimiento();
        print("Este es su Uber de Lujo, pal que tiene cualto.");
    }
}
