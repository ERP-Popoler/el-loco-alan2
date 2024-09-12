using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uber : MonoBehaviour
{
   [SerializeField][Range(0,10)] public int pasajero;

   public virtual void DarSeguimiento()
   {
      print("Uber tu mejor solucion.");
   }
}

