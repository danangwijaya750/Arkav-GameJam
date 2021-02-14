using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameButton : MonoBehaviour
{
    public void GoToMainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenuScene",LoadSceneMode.Single);
    }
    public void PlayAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
