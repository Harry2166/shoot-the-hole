using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject rotateAround;
    public float speed;
    public ScoreCounter ScoreCounter;

    [SerializeField] private float timeStart = 0;
    [SerializeField] private int per_second_increment = 2;

    public bool hit_exit = false;

    private void Update()
    {

        timeStart += Time.deltaTime;

        if (timeStart >= per_second_increment)
        {
            timeStart = 0f;
            speed++;
        }

        if (ScoreCounter.score % 2 == 0)
        {
            //speed++;
            transform.RotateAround(rotateAround.transform.position, Vector3.forward, -speed * Time.deltaTime);
        } else
        {
            //speed++;
            transform.RotateAround(rotateAround.transform.position, Vector3.forward, speed * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Projectile")
        {
            hit_exit = true;
        }
    }
}
