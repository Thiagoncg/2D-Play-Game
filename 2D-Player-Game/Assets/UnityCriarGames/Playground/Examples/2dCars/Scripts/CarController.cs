using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    //Serialize Variables
    [SerializeField]    private float gas = 1f;
    [SerializeField]    private float gasConsumer = 0.01f;
    [SerializeField]    private Rigidbody2D carBody;
    [SerializeField]    private Rigidbody2D frontTireRigidBody;
    [SerializeField]    private Rigidbody2D backTireRigidBody;
    [SerializeField]    private float speed;
    [SerializeField]    private float speedCar;
    [SerializeField] private Image imageGas;
 

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
        imageGas.fillAmount = gas;
    }

    private void AcelerationCar()
    {
        if (gas>0)
        {
            frontTireRigidBody.AddTorque(-movement * speed * Time.fixedDeltaTime);
            backTireRigidBody.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carBody.AddTorque(-movement * speedCar * Time.fixedDeltaTime);
        }

        gas -= gasConsumer * Mathf.Abs( movement ) * Time.fixedDeltaTime;
    }
}
