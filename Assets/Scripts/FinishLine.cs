using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FinishLine : BaseCheckpoint
{
    [SerializeField]
    private int laps = 3;

    [SerializeField]
    private SessionSettings settings = null;

    [SerializeField]
    private List<BaseCheckpoint> checkpoints = null;

    [SerializeField]
    public GameObject panelWinner;
    public GameObject pauseButton;

    [SerializeField]
    public TextMeshProUGUI textWinner;

    private bool gameOver = false;
    public TextMeshProUGUI textPlayer1Laps;
    public TextMeshProUGUI textPlayer2Laps;

    private void Awake()
    {
        if (settings != null)
        {
            laps = settings.Laps;
        }
        textPlayer1Laps.text=$"Lap to go : {laps}";
        textPlayer2Laps.text=$"Lap to go : {laps}";
    }

    public override void TriggerCheckpoint(Player player)
    {
        if (player.Checkpoints == null)
        {
            player.Checkpoints = new List<BaseCheckpoint>(checkpoints);
            return;
        }
        if (player.Checkpoints.Count > 0)
        {
            return;
        }
        player.Lap++;
        if(player.name=="Player 1"){
            textPlayer1Laps.text=$"Lap to go : {laps-player.Lap}";
        }else{
            textPlayer2Laps.text=$"Lap to go : {laps-player.Lap}";
        }
        player.Checkpoints.AddRange(checkpoints);
        if (player.Lap >= laps && !gameOver)
        {
            gameOver = true;
            Debug.Log($"{player.name} wins!");
            textWinner.text=$"{player.name} Wins!";
            panelWinner.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
