using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //[SerializeField] private float speed = 20f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject impactEffect;
    //[SerializeField] private AudioSource bullet_hit_sound_effect;
    // Start is called before the first frame update

    void Update()
    {
        if (transform.position.y > 5.5f || transform.position.y < -5.5f)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //bullet_hit_sound_effect.Play();
        GameObject effect = Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
