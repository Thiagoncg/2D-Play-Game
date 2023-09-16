using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGas : MonoBehaviour
{

    public PickupController pickupController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pickupController.gas = 1;
    }
}
