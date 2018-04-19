using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour
{

    AudioSource source;
    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void SetVolume(float value)
    {
        source.volume = value;
    }
}