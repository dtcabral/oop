using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddRelativeForce(Vector3.forward * 50 * verticalInput);
        playerRb.AddRelativeForce(Vector3.right * 50 * horizontalInput);


    }

    public  virtual void Block()
    {
       
    }

    public virtual void Fire()
    {

    }

}

