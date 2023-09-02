using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    //SERIALIZATION VARIABLES
    [SerializeField]    private Rigidbody2D carBody;
    [SerializeField]    private Rigidbody2D tireFrontRigdBody;
    [SerializeField]    private Rigidbody2D tireBackRigdBody;
    [SerializeField]    private float speed;
    [SerializeField]    private float speedCar;

    // PRIVATE VARIABLES
    private float movement;
    //private int coin = 0;

    private void FixedUpdate() 
    {
        MovementACar();
    }

    private void Update()
    {
        GetInputKeyBoard();
    }
    
    //----------------------------------------------------------------
    private void GetInputKeyBoard()
    {
        movement = Input.GetAxis("Horizontal");
    }

    //----------------------------------------------------------------
    private void MovementACar()
    {
        tireFrontRigdBody.AddTorque(-movement * speed * Time.fixedDeltaTime);                                                    
        tireBackRigdBody.AddTorque(-movement* speed * Time.fixedDeltaTime);
        carBody.AddTorque(-movement * speedCar * Time.fixedDeltaTime);
    }
}
