using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
   public ACounter ac;

   public int counter;

   public void AddCount()
   {
       counter = ac.acount + 1;
   }
}
