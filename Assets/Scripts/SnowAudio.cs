using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class SnowAudio : MonoBehaviour
{
    private void Awake()
    {
        RuntimeManager.PlayOneShot("event:/SnowOutside");
        RuntimeManager.PlayOneShot("event:/AmbientInside");
        RuntimeManager.GetVCA("vca:/Inside").setVolume(0);
    }
}
