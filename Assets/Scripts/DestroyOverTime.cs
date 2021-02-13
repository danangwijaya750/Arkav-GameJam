using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    [SerializeField, Min(0)]
    private float lifetime = 1;

    private void Awake()
    {
        Destroy(gameObject, lifetime);
    }
}
