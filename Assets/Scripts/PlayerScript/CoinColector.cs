using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinColector : MonoBehaviour
{
    public AudioClip collisionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();

            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }

            audioSource.clip = collisionSound;
            audioSource.Play();
            Destroy(other.gameObject);
        }
    }
}
