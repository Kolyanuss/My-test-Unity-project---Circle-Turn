using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScripts : MonoBehaviour
{
    public int score;
    public bool isMulti;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject effectBonus;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            Instantiate(effectBonus, transform.position, Quaternion.identity);
            if (isMulti)
            {
                score += 2;
            }
            else score++;
        }
        if (other.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Score", score);
            isMulti = false;
            PlayerPrefs.SetInt("isMulti", 0);
            Destroy(other.gameObject);

            SceneManager.LoadScene(2);
        }
    }

    private void Start()
    {
        isMulti = PlayerPrefs.GetInt("isMulti") == 1 ? true : false;
    }
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
