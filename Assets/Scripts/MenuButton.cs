using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButton : MonoBehaviour
{
    public GameObject panelLap;
    public void playGame(){
        panelLap.SetActive(true);
    }

    public void quitGame(){
        
    }

    public void select1Lap(){
        FinishLine.laps=1;
        startGame();
    }
    public void select2Laps(){
        FinishLine.laps=2;
        startGame();
    }
    public void select3Laps(){
        FinishLine.laps=3;
        startGame();
    }
    public void closePanel(){
        panelLap.SetActive(false);
    }
    private void startGame(){
        SceneManager.LoadScene("Test",LoadSceneMode.Single);
    }

}
