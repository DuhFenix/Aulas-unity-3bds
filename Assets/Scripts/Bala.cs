using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bala : MonoBehaviour
{
    public float speed = 10f;
    public static float pontosValor = 0f;
    private TextMeshProUGUI pontos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject objetoTexto = GameObject.Find("Pontos");

        if (objetoTexto != null)
        {
            pontos = objetoTexto.GetComponent<TextMeshProUGUI>();

            // Se encontrou o componente, atualiza o texto
            if (pontos != null && pontosValor == 0)
            {
                pontos.text = "Pontos: 0";
            }
        }
        else
        {
            Debug.LogWarning("Não foi possível encontrar um objeto com o nome 'Pontos' na cena!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("inimigo"))
        {
            pontosValor++;
            pontos.text = "Pontos : "+pontosValor;
            Destroy(obj.gameObject);
            Destroy(gameObject);
        }
    }
}
