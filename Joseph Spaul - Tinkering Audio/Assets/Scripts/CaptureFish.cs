using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureFish : MonoBehaviour
{
    //Delcaring public variable cash and private fishTag and fishScore
    public AudioClip cashSound;
    private string fishTag;
    private int fishScore;

    // Implementing collision method
    void OnCollisionEnter2D(Collision2D col)
    {
        // If the the object that this script is attached to collides with Blackfish, it will run this if statment
        if (col.gameObject.tag == "BlackFish")
        {
            //Setting the fishTag and fishScore variables to their appropriate amounts
            fishTag = "BlackFish";
            fishScore = 10;
        }

        // If the the object that this script is attached to collides with Redfish, it will run this if statment
        if (col.gameObject.tag == "RedFish")
        {
            fishTag = "RedFish";
            fishScore = 5;
        }

        // If the the object that this script is attached to collides with Yellowfish, it will run this if statment
        if (col.gameObject.tag == "YellowFish")
        {
            fishTag = "YellowFish";
            fishScore = 1;
        }

        // With the fishTag set, this if statment will run appropriatly and give the correct score value for each fish
        if (col.gameObject.tag == fishTag)
        {
            // It will play the cashSound, it will add the correct amount to the score and it will destroy the correct fish
            AudioSource.PlayClipAtPoint(cashSound, transform.position);
            ScoreScript.scoreValue += fishScore;
            Destroy(col.gameObject);
        }
    }

}

