using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	//We modify rigidbody with rb
	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// We changed Update to Fixed Update since we are using Physics
	void FixedUpdate () 
	{
		//Add a forward force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		//Add movement keys with WASD
		if ( Input.GetKey("d") )
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
		}
		if ( Input.GetKey("a") )
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
		}
		/*If we need WS
		if ( Input.GetKey("w") )
		{
			rb.AddForce(0, 0, 500 * Time.deltaTime);
		}
		if ( Input.GetKey("s") )
		{
			rb.AddForce(0, 0, -500 * Time.deltaTime);
		}
		*/
		
		//Add a Jump force
		if ( Input.GetKey("space") )
		{
			rb.AddForce(0, 500 * Time.deltaTime, 0);
		}
	}

}
