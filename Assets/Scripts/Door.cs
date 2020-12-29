using FMODUnity;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour {
    [SerializeField] Animator animator;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            RuntimeManager.PlayOneShot("event:/OpenDoor");
            animator.SetBool("character_nearby", true);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            RuntimeManager.PlayOneShot("event:/CloseDoor");
            animator.SetBool("character_nearby", false);
        }
    }
}
