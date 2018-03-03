using UnityEngine;

public class playermovement : MonoBehaviour {

    // this is a reference to the Rigidbody component called "rb" 
    public Rigidbody rb;

    public float forwardforce = 2000f;
	
    // we marked this as "Fixed"Update because we
    // are using it to mess with physics.
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardforce  * Time.deltaTime);// add a force of 2000 on the z-axis
    }
}
