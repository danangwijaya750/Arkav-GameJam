using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Lap { get; set; } = 0;
    public List<BaseCheckpoint> Checkpoints { get; set; } = null;

    [SerializeField]
    private Director director = null;

    [SerializeField]
    private LayerMask wallMask = default;

    [SerializeField]
    private LayerMask finishMask = default;

    [SerializeField]
    private string goButton = "Player 1";

    [SerializeField]
    private GameObject boostVFX = null;

    private Rigidbody2D rb;

    private void Awake()
    {
        TryGetComponent(out rb);
    }

    private void Update()
    {
        if (Input.GetKeyDown(goButton))
        {
            Go();
        }
    }

    public void Go()
    {
        var hit = Physics2D.Raycast(transform.position, director.transform.rotation * Vector3.up, 100, wallMask);
        if (hit)
        {
            var direction = (hit.point - (Vector2)transform.position).normalized;
            var distance = Vector3.Distance(transform.position, hit.point);
            var finishHit = Physics2D.Raycast(transform.position, director.transform.rotation * Vector3.up, distance, finishMask);
            if (finishHit && finishHit.transform.TryGetComponent(out BaseCheckpoint checkpoint))
            {
                checkpoint.TriggerCheckpoint(this);
            }
            transform.position = hit.point - (direction * 0.1f);
            transform.rotation = director.transform.rotation;
            var effect = Instantiate(boostVFX, transform.position, transform.rotation);
            var particle = effect.GetComponent<ParticleSystem>();
            var shape = particle.shape;
            shape.length = distance;
        }
    }
}
