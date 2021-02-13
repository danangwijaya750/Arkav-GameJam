using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : BaseCheckpoint
{
    public override void TriggerCheckpoint(Player player)
    {
        if (player.Checkpoints.Count <= 0 || !player.Checkpoints[0].Equals(this))
        {
            return;
        }
        player.Checkpoints.Remove(this);
    }
}