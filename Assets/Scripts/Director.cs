using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    [SerializeField]
    private SessionSettings settings = null;

    private Vector3 target = Vector3.forward;

    private void Awake()
    {
        if (settings != null)
        {
            speed = settings.Difficulty;
        }
    }

    private void FixedUpdate()
    {
        if (transform.localRotation.z >= 0.7 && target == Vector3.forward)
        {
            target = Vector3.back;
        }

        if (transform.localRotation.z <= -0.7 && target == Vector3.back)
        {
            target = Vector3.forward;
        }
        transform.Rotate(target * speed);
    }
}
