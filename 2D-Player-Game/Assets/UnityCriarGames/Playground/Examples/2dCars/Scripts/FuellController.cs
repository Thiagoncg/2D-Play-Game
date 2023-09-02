using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuellController : MonoBehaviour
{
     [SerializeField] private Image imageFuellSlider; 
     private float fullGas = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gas"))
        {
            Debug.Log("Capturou a Gasolina"); 
            imageFuellSlider.fillAmount = fullGas;
            Destroy(other.gameObject);
        }
    }
}
//Exercício:
//Ao clicar nos controles de acelerar o carro
//o indicador de gasolina deve diminuir
//e quando o carro colidir com o galão
//o indicador de ficar cheio.
