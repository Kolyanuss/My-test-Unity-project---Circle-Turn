using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScripts : MonoBehaviour
{
    public int score;
    [SerializeField] Text scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            score++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Enemy")
        {
            if (score > 0)
            {
                score--;
            }
            else
            {
                scoreText.text = "End Game";
            }


            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
