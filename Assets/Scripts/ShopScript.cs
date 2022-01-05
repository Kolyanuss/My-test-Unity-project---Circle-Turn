using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopScript : MonoBehaviour
{
    public int money;
    public Text moneyText;
    public Text byuButtonText;
    public bool isMulti;
    public int multiPrice = 5;
    void Start()
    {
        //multiPrice = 5;
        money = PlayerPrefs.GetInt("Money");
        UpdateMoneyText();
        isMulti = PlayerPrefs.GetInt("isMulti") == 1 ? true : false;
        if (isMulti)
        {
            byuButtonText.text = "Куплено";
        }
        else byuButtonText.text = multiPrice + "₴";
    }

    void UpdateMoneyText()
    {
        moneyText.text = "Гривні: " + money.ToString();
    }

    public void BuyMulti()
    {
        if (money >= multiPrice && !isMulti)
        {
            isMulti = true;
            money -= multiPrice;
            byuButtonText.text = "Куплено";
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("isMulti", isMulti ? 1 : 0);
        }

        UpdateMoneyText();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
