using UnityEngine;
using UnityEngine.UI;

public class FillAmount : MonoBehaviour
{
    public Image fillImage;  // Referência à imagem preenchível

    void Start()
    {
        // Obtenha a referência à imagem preenchível
        fillImage = GetComponent<Image>();
    }

    void Update()
    {
        // Exemplo: preencha a imagem gradualmente ao longo do tempo
        float fillSpeed = 0.2f;  // Taxa de preenchimento por segundo

        // Verifique se o preenchimento atual é menor que 1 (100%)
        if (fillImage.fillAmount >= 0.1f)
        {
            // Aumente gradualmente o preenchimento
            fillImage.fillAmount -= fillSpeed * Time.deltaTime;
        }
        else
        {
            // O preenchimento atingiu 100%, faça alguma coisa aqui
            Debug.Log("A Gasolina Acabou");
        }
    }
}
