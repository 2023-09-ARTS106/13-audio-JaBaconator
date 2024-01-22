using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    public AudioClip splashSound;
    public AudioSource audioS;     //a reference to my audio source

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            Debug.Log("Entered the Water");
            audioS.PlayOneShot(splashSound);
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            Debug.Log("Exited the Water");
            audioS.PlayOneShot(splashSound);
        } 
    }
}
