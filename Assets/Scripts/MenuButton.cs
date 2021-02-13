using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButton : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene("Test",LoadSceneMode.Single);
    }

    public void quitGame(){

    }
}
