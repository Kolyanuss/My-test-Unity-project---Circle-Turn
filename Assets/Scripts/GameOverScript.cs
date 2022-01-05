using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public int score;
    public Text scoreText;

    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        scoreText.text += " " + score.ToString();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
