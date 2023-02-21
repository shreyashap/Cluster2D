using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 moveDirection;
    private float moveY = 0f;
    private float moveX = 0f;

    private Rigidbody2D playerRb;
    [SerializeField] private float moveSpeed =5f;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            moveY = +1f;

        if (Input.GetKey(KeyCode.S))
            moveY = -1f;

        if (Input.GetKey(KeyCode.A))
            moveX = -1f;

        if (Input.GetKey(KeyCode.D))
            moveX = +1f;

        moveDirection = new Vector2(moveX, moveY).normalized;

    }

    private void FixedUpdate()
    {
        playerRb.velocity = moveDirection * moveSpeed;
    }
}
