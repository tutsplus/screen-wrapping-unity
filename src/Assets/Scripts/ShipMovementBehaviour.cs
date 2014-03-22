using UnityEngine;
using System.Collections;

public class ShipMovementBehaviour : MonoBehaviour
{
	public float moveSpeed = 10f;
	public float rotationSpeed = 180f;
	
	// Update is called once per frame
	void Update()
	{
		var horizontalAxis = Input.GetAxis("Horizontal");
		var verticalAxis = Input.GetAxis("Vertical");
		
		// Turn left or right on left/right buttons
		transform.Rotate(0, 0, -horizontalAxis * Time.deltaTime * rotationSpeed);
		
		// Move forward
		transform.Translate(Vector3.right * verticalAxis * Time.deltaTime * moveSpeed);
	}
}
