using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
   public ACounter ac;

   int add = 1;

   public int counter;

   public int acount = 0;

   public void AddCount()
   {
       counter = ac.acount + add;
   }
}
