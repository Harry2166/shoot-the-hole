using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject Score1;
    [SerializeField] private TextMeshProUGUI pointsText;
    public void Setup(int score)
    {
        Score1.SetActive(false);
        gameObject.SetActive(true);
        pointsText.text = "Score: " + score.ToString();
    }
}
