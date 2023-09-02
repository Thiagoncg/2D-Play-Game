using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteColisores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Verfica Colisão
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Player collided with an obstacle.");
            // Aqui você pode adicionar código para lidar com a colisão.
        }
        Debug.Log("Colidium detected");
    }

    //Verifica colisão por trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collected a coin.");
            // Aqui você pode adicionar código para coletar a moeda.
        }
        Debug.Log("Entrou no objeto");
    }
}
