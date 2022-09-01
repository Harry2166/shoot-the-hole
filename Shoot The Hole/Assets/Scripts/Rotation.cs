using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject rotateAround;
    public float speed;
    public ScoreCounter ScoreCounter;

    private void Update()
    {
        if(ScoreCounter.score % 2 == 0)
        {
            transform.RotateAround(rotateAround.transform.position, Vector3.forward, -speed * Time.deltaTime);
        } else
        {
            transform.RotateAround(rotateAround.transform.position, Vector3.forward, speed * Time.deltaTime);
        }
    }

}
