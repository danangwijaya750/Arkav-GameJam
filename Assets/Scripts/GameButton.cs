using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameButton : MonoBehaviour
{
    public void GoToMainMenu(){
        SceneManager.LoadScene("MainMenuScene",LoadSceneMode.Single);
    }
    public void PlayAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
