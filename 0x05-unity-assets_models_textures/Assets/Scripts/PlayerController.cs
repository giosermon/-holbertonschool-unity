using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 5f;
    public float jumpHeight = 4f;
    public float gravityValue = -10f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}

    //void FixedUpdate()
    //{
    //    // Press up
    //    if (Input.GetKey("w"))
    //    {
    //        player.AddForce(0, 0, speed * Time.deltaTime);
    //    }
    //    // Press down
    //    if (Input.GetKey("s"))
    //    {
    //        player.AddForce(0, 0, -speed * Time.deltaTime);
    //    }
    //    // Press left
    //    if (Input.GetKey("a"))
    //    {
    //        player.AddForce(-speed * Time.deltaTime, 0, 0);
    //    }
    //    // Press right
    //    if (Input.GetKey("d"))
    //    {
    //        player.AddForce(speed * Time.deltaTime, 0, 0);
    //    }
    //}

