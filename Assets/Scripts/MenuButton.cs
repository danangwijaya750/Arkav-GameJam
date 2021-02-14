using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButton : MonoBehaviour
{
    public GameObject panelLap;

    [SerializeField]
    private SessionSettings session = null;

    [SerializeField]
    private SessionSettings defaultSettings = null;

    private void Awake()
    {
        if (defaultSettings != null)
        {
            session.Laps = defaultSettings.Laps;
            session.Difficulty = defaultSettings.Difficulty;
        }
    }

    public void playGame(){
        panelLap.SetActive(true);
    }

    public void quitGame(){
        
    }

    public void SetLaps(int laps)
    {
        session.Laps = laps;
    }

    public void SetDifficulty(int difficulty)
    {
        session.Difficulty = difficulty;
    }

    public void closePanel(){
        panelLap.SetActive(false);
    }
    public void startGame(){
        SceneManager.LoadScene("Test",LoadSceneMode.Single);
    }

}
