using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureFish : MonoBehaviour
{
    public AudioClip cash;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "BlackFish")
        {
            AudioSource.PlayClipAtPoint(cash, transform.position);
            ScoreScript.scoreValue += 10;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "RedFish")
        {
            AudioSource.PlayClipAtPoint(cash, transform.position);
            ScoreScript.scoreValue += 5;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "YellowFish")
        {
            AudioSource.PlayClipAtPoint(cash, transform.position);
            ScoreScript.scoreValue += 1;
            Destroy(col.gameObject);
        }
    }

}

