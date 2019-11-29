using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAiming : MonoBehaviour
{
    public GameObject crosshairs;
    public GameObject player;
    public Camera mainCamera;
    public GameObject projectile;
    public GameObject firePoint;
    public float projectileSpeed;
    public float minRot;
    public float maxRot;
    public AudioSource fireSound;

    private Vector3 target;

    
    private void Start()
    {
        Cursor.visible = false;
        // Added Audio to the player shooting
        fireSound = GetComponent<AudioSource>();
    }

    
    private void Update()
    {
        target = mainCamera.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);
        Vector3 characterScale = transform.localScale;

        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        
        if((rotationZ >= minRot) && (rotationZ <= maxRot))
        {
            player.transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        }

        if((rotationZ <= 90))
        {
            transform.localScale = characterScale;
        }


        if (Input.GetMouseButtonDown(0))
        {
            fireSound.pitch = Random.Range(1, 4);
            fireSound.reverbZoneMix = Random.Range(0, 2);
            fireSound.Play();
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            FireBullet(direction, rotationZ);

        }
    }
    void FireBullet(Vector2 direction, float rotationZ)
    {
        //Vector3 firingDir = direction;

        //if (pMove.facingRight)
        //{

        //}


        GameObject proj = Instantiate(projectile, firePoint.transform.position, Quaternion.Euler(0.0f, 0.0f, rotationZ)) as GameObject;
        proj.GetComponent<Rigidbody2D>().velocity = direction * projectileSpeed;
    }

}
