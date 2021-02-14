using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameButton : MonoBehaviour
{
    public GameObject PausePanel;

    public void GoToMainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenuScene",LoadSceneMode.Single);
    }
    public void PlayAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PauseGame(){
        PausePanel.SetActive(true);
        Time.timeScale=0;
    }
    public void UnPauseGame(){
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

}
