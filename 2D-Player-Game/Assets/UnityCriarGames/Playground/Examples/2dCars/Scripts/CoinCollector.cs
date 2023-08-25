using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private  TMP_Text coinLabel;
    private int coin = 0;
    void Start()
    {
        Debug.Log("Funcionando...");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Player collected a coin.");
            coin++;
            Debug.Log("Coin received: " + coin);
            Destroy(other.gameObject);

            coinLabel.text = coin.ToString();
        }
    }
}
