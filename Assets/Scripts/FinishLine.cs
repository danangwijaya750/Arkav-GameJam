using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : BaseCheckpoint
{
    [SerializeField]
    private int laps = 3;

    [SerializeField]
    private List<BaseCheckpoint> checkpoints = null;

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
        }
    }
}
