using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private CharacterController controller;
    private Vector3 moveVector;
    private float verticalVelocity = 0f;
    private float gravity = 12f;

    public float speed = 5f;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        moveVector.z = speed;
        moveVector.y = verticalVelocity;
        controller.Move(moveVector * Time.deltaTime);
	}
}
