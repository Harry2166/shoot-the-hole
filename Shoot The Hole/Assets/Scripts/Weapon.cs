using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    //public int bulletCount = 5;
    //private int countBullet = 5;
    //public bool isCollected = false;
    // Update is called once per frame
    void Update() {

        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.F)))
        {
            Shoot();
            //isCollected = false;
        }

    }
    void Shoot(){
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //bulletCount -= 1;
    }

}
