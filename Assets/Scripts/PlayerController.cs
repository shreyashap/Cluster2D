using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 moveDirection;
    private Rigidbody2D playerRb;
    [SerializeField] private float moveSpeed =5f;
    private PlayerAnimationHandler playerAnimation;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<PlayerAnimationHandler>();
    }
    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(moveX, moveY).normalized;

    }

    private void FixedUpdate()
    {
        playerRb.velocity = moveDirection * moveSpeed;
    }
}
