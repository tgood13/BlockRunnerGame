using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] public float lateral = 0.1f;
    [SerializeField] private KeyCode leftKey = KeyCode.LeftArrow;
    [SerializeField] private KeyCode rightKey = KeyCode.RightArrow;

    private Vector3 startingPosition;
    public ObstacleSpawner obstacleSpawner;

    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftKey))
        {
            MoveLeft();
        }

        if (Input.GetKey(rightKey))
        {
            MoveRight();
        }
    }

    private void MoveLeft()
    {
        Vector3 position = transform.position;
        position.x -= lateral;
        transform.position = position;
    }

    private void MoveRight()
    {
        Vector3 position = transform.position;
        position.x += lateral;
        transform.position = position;
    }

    private void Reset()
    {
        transform.position = startingPosition;
        obstacleSpawner.RemoveObstacles();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Cube crashed into the block wall
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Reset();
        }
    }

}

