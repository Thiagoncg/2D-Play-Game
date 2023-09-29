using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupController : MonoBehaviour
{
    //SERIALIZATION VARIABLES
    [SerializeField]    private Rigidbody2D carBody;
    [SerializeField]    private Rigidbody2D tireFrontRigdBody;
    [SerializeField]    private Rigidbody2D tireBackRigdBody;
    [SerializeField]    private float speed;
    [SerializeField]    private float speedCar;
    [SerializeField]    private Image imageGas;
    [SerializeField]    private GameObject panelGameOver;
    [SerializeField]    private int carDrive;

    //PUBLIC VARIABLES
    public float gas = 1f;
    public float gasConsumer = 0.01f;       

    //PRIVATE VARIABLES
    private float movement;
    private void Start()
    {
        panelGameOver.SetActive(false);
    }

    private void FixedUpdate() 
    {
        MovementACar();
    }

    private void Update()
    {
        GetInputKeyBoard();
        VerificGasolina();
    }
    
    //----------------------------------------------------------------
    private void GetInputKeyBoard()
    {
        movement = Input.GetAxis("Horizontal");
        imageGas.fillAmount = gas;
    }

    //----------------------------------------------------------------
    private void MovementACar()
    {
        if (gas>0)
        {
            tireFrontRigdBody.AddTorque(-movement * speed * Time.fixedDeltaTime);
            tireBackRigdBody.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carBody.AddTorque(-movement * speedCar * Time.fixedDeltaTime);
        }
        gas -= gasConsumer * Mathf.Abs(movement) * Time.fixedDeltaTime * 10;
    }

    public void MoveCarMObile()
    {
        if (gas > 0)
        {
            tireFrontRigdBody.AddTorque(-carDrive * speed * Time.fixedDeltaTime);
            tireBackRigdBody.AddTorque(-carDrive * speed * Time.fixedDeltaTime);
            carBody.AddTorque(-carDrive * speedCar * Time.fixedDeltaTime);
        }
        gas -= gasConsumer * Mathf.Abs(movement) * Time.fixedDeltaTime * 10;
    }

    private void CacheCarDrive()
    {
        carDrive++;
    }

    private void VerificGasolina()
    {
        if (imageGas.fillAmount <= 0)
        {
            panelGameOver.SetActive(true);
        }
    }
}
//Prova = 7 Pontos
// Trabalho em Grupo = 3 pontos
//Até 4 pessoas.
// Replica do jogo desenvolvido em sala de aula
// Plataforma Android. Enviar o APK.
