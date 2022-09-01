using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathTracker : MonoBehaviour
{

    public Rotation Rotation;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Projectile")
        {
            if (!Rotation.hit_exit)
            {
                Debug.Log("L NOOB RATIO!");
            } else
            {
                Debug.Log("Nice!");
                Rotation.hit_exit = false;
            }
        }
    }

}

