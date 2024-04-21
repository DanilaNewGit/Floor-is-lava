using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject deadMenu;
    public GameObject winMenu;
    public ParticleSystem winParticle;
    public ParticleSystem deathParticle;

    private void Start()
    {
        winParticle.Stop();
        deathParticle.Stop();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            deadMenu.SetActive(true);
            deathParticle.Play();

        }
        else if (collision.gameObject.CompareTag("Finish"))
        {
            winMenu.SetActive(true);
            winParticle.Play();
        }
    }
}
