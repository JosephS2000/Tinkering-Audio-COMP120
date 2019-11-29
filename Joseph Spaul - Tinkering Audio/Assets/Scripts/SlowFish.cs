﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowFish : MonoBehaviour
{
    // Added Audio to fish getting hit
    public AudioClip Hurt;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Projectile")
        {
            AudioSource.PlayClipAtPoint(Hurt, transform.position);
            gameObject.GetComponent<FishMoving>().speed = 0;
        }
    }

}

