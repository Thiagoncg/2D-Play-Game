using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //Serialize Variables
    [SerializeField]    private Rigidbody2D carBody;
    [SerializeField]    private Rigidbody2D frontTireRigidBody;
    [SerializeField]    private Rigidbody2D backTireRigidBody;
    [SerializeField]    private float speed;
    [SerializeField]    private float speedCar;

    //private Variables
    private float movement;


    void Update()
    {
        GetImputKeyboard();
    }

    private void FixedUpdate()
    {
        AcelerationCar();
    }

    //My Functions
    private void GetImputKeyboard()
    {
        movement = Input.GetAxis("Horizontal");
        Debug.Log("Horizontal movement" + movement);
    }

    private void AcelerationCar()
    {
        frontTireRigidBody.AddTorque( -movement * speed * Time.fixedDeltaTime );
        backTireRigidBody.AddTorque( -movement * speed * Time.fixedDeltaTime );
        carBody.AddTorque( -movement * speedCar * Time.fixedDeltaTime );
    }
}
