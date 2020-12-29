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
                RuntimeManager.GetVCA("vca:/Outside").setVolume(0);
                RuntimeManager.GetVCA("vca:/Inside").setVolume(1);
            }
            else
            {
                RuntimeManager.GetVCA("vca:/Outside").setVolume(1);
                RuntimeManager.GetVCA("vca:/Inside").setVolume(0);
            }
        }
    }
}
