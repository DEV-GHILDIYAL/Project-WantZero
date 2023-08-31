using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseGameUI;
    private void Start()
    {
        pauseGameUI.SetActive(false);
    }
    public void PauseGame()
    {
        Debug.Log("Pause");
        Time.timeScale = 0f;
        pauseGameUI.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseGameUI.SetActive(false);
    }
}
