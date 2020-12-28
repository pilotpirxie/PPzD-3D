using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class DesertAudio : MonoBehaviour
{
    private void Awake()
    {
        RuntimeManager.PlayOneShot("event:/AmbientOutside");
        RuntimeManager.PlayOneShot("event:/AmbientInside");
    }
}
