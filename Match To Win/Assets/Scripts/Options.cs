using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour {

    public Slider Volume;
    public AudioSource myMusic;
 
    void Update () {
        if (myMusic != null)  {
            myMusic.volume = Volume.value;
           
        }
    }
}