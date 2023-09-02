using UnityEngine;
using UnityEngine.UI;

public class FillAmount : MonoBehaviour
{
    public Image fillImage;  // Refer�ncia � imagem preench�vel

    void Start()
    {
        // Obtenha a refer�ncia � imagem preench�vel
        fillImage = GetComponent<Image>();
    }

    void Update()
    {
        // Exemplo: preencha a imagem gradualmente ao longo do tempo
        float fillSpeed = 0.2f;  // Taxa de preenchimento por segundo

        // Verifique se o preenchimento atual � menor que 1 (100%)
        if (fillImage.fillAmount >= 0.1f)
        {
            // Aumente gradualmente o preenchimento
            fillImage.fillAmount -= fillSpeed * Time.deltaTime;
        }
        else
        {
            // O preenchimento atingiu 100%, fa�a alguma coisa aqui
            Debug.Log("A Gasolina Acabou");
        }
    }
}
