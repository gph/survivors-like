using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed;

    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (targetPosition != transform.position)
            transform.position = Vector3.MoveTowards(transform.position, targetPosition,
                Time.fixedDeltaTime * enemySpeed);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("trigger");
        targetPosition = other.transform.position;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        targetPosition = transform.position;
    }
}