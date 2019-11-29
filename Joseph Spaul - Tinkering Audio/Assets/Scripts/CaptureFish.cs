using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureFish : MonoBehaviour
{
    //Delcaring publis variable cash
    public AudioClip cashSound;

    // Implementing collision method
    void OnCollisionEnter2D(Collision2D col)
    {
        // If the the object that this script is attached to collides with Blackfish, it will run this if statment
        if (col.gameObject.tag == "BlackFish")
        {
            // It will play the cashSound, it will add 10 to the score and it will destroy the gameObject BlackFish
            AudioSource.PlayClipAtPoint(cashSound, transform.position);
            ScoreScript.scoreValue += 10;
            Destroy(col.gameObject);
        }

        // If the the object that this script is attached to collides with Redfish, it will run this if statment
        if (col.gameObject.tag == "RedFish")
        {
            // It will play the cashSound, it will add 10 to the score and it will destroy the gameObject RedFish
            AudioSource.PlayClipAtPoint(cashSound, transform.position);
            ScoreScript.scoreValue += 5;
            Destroy(col.gameObject);
        }

        // If the the object that this script is attached to collides with Redfish, it will run this if statment
        if (col.gameObject.tag == "YellowFish")
        {
            // It will play the cashSound, it will add 10 to the score and it will destroy the gameObject RedFish
            AudioSource.PlayClipAtPoint(cashSound, transform.position);
            ScoreScript.scoreValue += 1;
            Destroy(col.gameObject);
        }
    }

}

