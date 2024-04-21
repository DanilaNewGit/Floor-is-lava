using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip collisionSound;
    private string objectTag;
    bool needToPlay = true;
    private void Start()
    {
        objectTag = this.tag;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (needToPlay)
        {
            AudioSource audioSource = GetComponent<AudioSource>();

            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }

            audioSource.clip = collisionSound;
            audioSource.Play();
            if (tag == "Finish")
            {
                needToPlay = false;
            }
        }
    }
}
