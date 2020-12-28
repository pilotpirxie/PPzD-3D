using FMODUnity;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public bool isTriggeringInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (isTriggeringInside)
            {
                RuntimeManager.GetVCA("vca:/DesertOutside").setVolume(0);
            }
            else
            {
                RuntimeManager.GetVCA("vca:/DesertOutside").setVolume(1);
            }
        }
    }
}
