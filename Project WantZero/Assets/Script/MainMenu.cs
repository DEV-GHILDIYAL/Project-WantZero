using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject sureToExitUI;
    public TextMeshProUGUI lowscore;
    public int lowScore;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;

        sureToExitUI.SetActive(false);
    }
}
