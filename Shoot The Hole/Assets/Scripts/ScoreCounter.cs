using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private TextMeshProUGUI TextElement;
    public Rotation Rotation;

    private void Start()
    {
        TextElement.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //bullet_hit_sound_effect.Play();

        if (col.gameObject.tag == "Projectile")
        {
            score++;
            TextElement.text = score.ToString();
        }

    }
}
