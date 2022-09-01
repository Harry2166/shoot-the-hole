using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //[SerializeField] private float speed = 20f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject impactEffect;
    public bool hit_exit = false;
    //[SerializeField] private AudioSource bullet_hit_sound_effect;
    // Start is called before the first frame update

    void Update()
    {
        if (transform.position.y > 5.5f || transform.position.y < -5.5f)
        {
            //Debug.Log(transform.position.y);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //bullet_hit_sound_effect.Play();

        if(col.gameObject.tag == "Exit")
        {
            hit_exit = true;
        }

        if (col.gameObject.tag == "Goal")
        {
            if (hit_exit)
            {
                createBullet();
            } else
            {
                createBullet();
            }
        }
    }

    void createBullet()
    {
        GameObject effect = Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }

}
