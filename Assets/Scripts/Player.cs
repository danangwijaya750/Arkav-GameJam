﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Director director = null;

    [SerializeField]
    private LayerMask wallMask = default;

    private Rigidbody2D rb;

    private void Awake()
    {
        TryGetComponent(out rb);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            var hit = Physics2D.Raycast(transform.position, director.transform.rotation * Vector3.up, 100, wallMask);
            if (hit)
            {
                var direction = (hit.point - (Vector2)transform.position).normalized;
                transform.position = hit.point - (direction * 0.1f);
                transform.rotation = director.transform.rotation;
            }
        }
        Debug.DrawRay(transform.position, director.transform.rotation * Vector3.up * 100, Color.green);
    }
}