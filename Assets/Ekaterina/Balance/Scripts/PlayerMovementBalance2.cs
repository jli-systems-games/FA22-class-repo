using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina {
	
	public class PlayerMovementBalance2 : MonoBehaviour
	{ 
		public CharacterController2DBalance2 controller;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;



	void Update () {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
	}
	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		jump = false;
	}
}
}
