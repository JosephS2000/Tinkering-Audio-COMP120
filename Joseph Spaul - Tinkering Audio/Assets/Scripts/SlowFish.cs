using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowFish : MonoBehaviour
{
    //Delcaring public variable hurtSound
    public AudioSource hurtSound;

    void Start()
    {
        //Referencing the audio source component
        hurtSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //When the oject that this script is attached to collides with an object with the tag Projectile, it will run this if statment 
        if (col.gameObject.tag == "Projectile")
        {
            //These will randomly modulate the pitch, reverb and panning of the sound as it plays
            //It will also set the speed of the fish entity to 0 
            hurtSound.pitch = Random.Range(1, 4);
            hurtSound.reverbZoneMix = Random.Range(0, 2);
            hurtSound.panStereo = Random.Range(-2, 2);
            hurtSound.Play();
            gameObject.GetComponent<FishMoving>().speed = 0;
        }
    }

}

