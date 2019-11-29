using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowFish : MonoBehaviour
{
    public AudioSource hurt;

    void Start()
    {
        hurt = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Projectile")
        {
            hurt.pitch = Random.Range(1, 4);
            hurt.reverbZoneMix = Random.Range(0, 2);
            hurt.panStereo = Random.Range(-2, 2);
            hurt.Play();
            gameObject.GetComponent<FishMoving>().speed = 0;
        }
    }

}

