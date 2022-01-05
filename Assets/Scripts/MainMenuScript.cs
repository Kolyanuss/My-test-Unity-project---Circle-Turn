using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public int money;
    public int earnedMoney;
    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text += money.ToString();
        PlayerPrefs.SetInt("Score", 0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
