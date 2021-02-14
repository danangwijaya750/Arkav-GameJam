using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Settings", menuName = "Game Session Settings")]
public class SessionSettings : ScriptableObject
{
    public int Laps { get => laps; set => laps = value; }
    public float Difficulty { get => difficulty; set => difficulty = value; }

    [SerializeField]
    [Min(0)]
    private int laps = 0;

    [SerializeField]
    [Min(0)]
    private float difficulty = 5;
}
