﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowFish : MonoBehaviour
{
    // Added Audio to fish getting hit
    public AudioSource Hurt;

    private void Start()
    {
        Hurt = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Projectile")
        {
            gameObject.GetComponent<FishMoving>().speed = 0;
            Hurt.Play();
        }
    }

}

