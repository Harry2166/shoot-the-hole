using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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

    public void RestartButton()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
    }

    public void ExitButton()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
