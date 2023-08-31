using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public GameObject initialScreen;
    public TMP_InputField initialPointText;
    public int initialPoint;
    public int point;
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI notice;
    public PlayerController pc;
    public GameObject won;
    public bool Iswon;

    // Start is called before the first frame update
    void Start()
    {
        Iswon = false;
        notice.text = "";
        initialScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    private void Update()
    {
        if (pointsText.text == "0")
        {
            Iswon = true;
            won.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void StartGame()
    {
        
        try
        {
            if (initialPointText.text == "")
            {
                notice.text = "pleae enter initial value";
            }
            else if (initialPointText.text == "0")
            {
                notice.text = "You can select 0 as a initial value";
            }
            else
            {
                notice.text = "Done";
                initialPoint = Convert.ToInt32(initialPointText.text);
                point = initialPoint;
                pointsText.text = point.ToString();
                initialScreen.SetActive(false);
                Time.timeScale = 1f;
            }
        }catch(Exception)
        {
            notice.text = "Please enter only number";
        }
    }
}
