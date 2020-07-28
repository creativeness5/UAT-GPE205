using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BulletData))]
public class Shooting : MonoBehaviour
{
    public GameObject shootingPoint;
    public GameObject bullets;

    public BulletData bulletData;

    public bool canShoot;

    public float timerDelay = 3.0f;
    private float nextEventTime;

    void Start()
    {
        nextEventTime = Time.time + timerDelay;
        bulletData = bullets.GetComponent<BulletData>();
    }

    void Update()
    {
        if (Time.time >= nextEventTime)
        {
            canShoot = true;
            Debug.Log("Fire at will.");
            nextEventTime = Time.time + timerDelay;
        }
           
        if(canShoot == true)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletShot;
            bulletShot = Instantiate(bullets, shootingPoint.transform.position, Quaternion.identity) as GameObject;
            // Spawn the bullet prefab at the ShootingPoint position times the speed that designers can mess around with, with no rotation

            bulletShot.GetComponent<Rigidbody>().AddForce(shootingPoint.transform.forward * bulletData.bulletSpeed);

            Destroy(bulletShot, 3.0f);
            // Destroy the new bullet after 3 seconds

            canShoot = false;
            Debug.Log("Shot a bullet from " + gameObject.name);
        }
    }
}
