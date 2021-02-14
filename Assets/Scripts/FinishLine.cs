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

    [SerializeField]
    public TextMeshProUGUI textWinner;

    private void Awake()
    {
        if (settings != null)
        {
            laps = settings.Laps;
        }
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
        player.Checkpoints.AddRange(checkpoints);
        if (player.Lap >= laps)
        {
            Debug.Log($"{player.name} wins!");
            textWinner.text=$"{player.name} Wins!";
            panelWinner.SetActive(true);
        }
    }
}
