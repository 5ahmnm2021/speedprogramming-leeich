using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ACounter : MonoBehaviour
{   
    public AddScore adscore;
    public int acount = 0;
    public Text answer;

    void Start() {
        answer.text = adscore.counter;
    }
}
