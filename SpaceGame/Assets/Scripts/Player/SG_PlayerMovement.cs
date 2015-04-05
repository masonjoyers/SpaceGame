using UnityEngine;
using System.Collections;

public class SG_PlayerMovement : MonoBehaviour {

	// Setup the varibles for the player
	public float maxSpeed = 1.0f;
	public float currentSpeed = 0.6f;
	public float boostSpeed = 0.2f;

	public float maxYaw = 42.0f;
	public float maxPitch = 42.0f;
	public float maxRoll = 42.0;
	public float currentYaw = 0.0f;
	public float currentPitch = 0.0f;
	public float currentRoll = 0.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// FixedUpdate is call for physics operations.
	void FixedUpdate ()
	{
		// Store the input axes.
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		

	}
}
