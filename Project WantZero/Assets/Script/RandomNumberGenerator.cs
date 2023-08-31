using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomNumberGenerator : MonoBehaviour
{
    public TextMeshProUGUI num1;
    public TextMeshProUGUI num2;
    public TextMeshProUGUI num3;

    public int randomNum1;
    public int randomNum2;
    public int randomNum3;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        if (gameManager.level == 1)
        {
            randomNum1 = Random.Range(-25, 25);
            randomNum2 = Random.Range(-25, 25);
            randomNum3 = Random.Range(-25, 25);
            num1.text = randomNum1.ToString();
            num2.text = randomNum2.ToString();
            num3.text = randomNum3.ToString();
        }
        else if (gameManager.level == 2)
        {
            randomNum1 = Random.Range(-50, 50);
            randomNum2 = Random.Range(-50, 50);
            randomNum3 = Random.Range(-50, 50);
            num1.text = randomNum1.ToString();
            num2.text = randomNum2.ToString();
            num3.text = randomNum3.ToString();
        }
        else if (gameManager.level == 3)
        {
            randomNum1 = Random.Range(-100, 100);
            randomNum2 = Random.Range(-100, 100);
            randomNum3 = Random.Range(-100, 100);
            num1.text = randomNum1.ToString();
            num2.text = randomNum2.ToString();
            num3.text = randomNum3.ToString();
        }
    }
}
