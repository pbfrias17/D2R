﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Called before physics calculations
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
	}
}
