using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    private Text text;
    private int numOfCoin = 0;
    private int countCoin = 0;
    private string defaultText = "Coin: {0} / {1}";

    public void OnReady(int numOfGoal)
    {
        numOfCoin = numOfGoal;
        text = GetComponent<Text>();
        text.text = string.Format(defaultText, countCoin, numOfCoin);
    }

    public void OnPointerClick()
    {
        countCoin++;
        if (countCoin == numOfCoin)
        {
            StartCoroutine(RestartCoroutine());
        }
        else
        {
            text.text = string.Format(defaultText, countCoin, numOfCoin);
        }
    }

    IEnumerator RestartCoroutine()
    { 
        text.text = "You Collect All Coins!";
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
