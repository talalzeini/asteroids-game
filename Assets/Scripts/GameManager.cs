using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject TryAgainUI;
    public GameObject player;
    public void TryAgain()
    {
        TryAgainUI.SetActive(true);
    }
    public void Update()
    {
        if(TryAgainUI.activeSelf)
        {
            Destroy(player);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Second");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
     public void QuitGame()
    {
        Application.Quit();
    }
}
