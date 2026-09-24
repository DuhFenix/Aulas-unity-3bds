using UnityEngine;

public class chamarInimigos : MonoBehaviour
{
    private Vector3 Esquerda;
    private Vector3 Direita;
    public GameObject inimigo;
    public float intervalo = 3f;
    private float ultimoInvocacao = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Esquerda = new Vector3(-331.100006f, 0f, 46.2000008f);
        Direita = new Vector3(-299.399994f, 0f, 46.2000008f);
        ultimoInvocacao = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - ultimoInvocacao >= intervalo)
        {
            InvocarInimigo();
            ultimoInvocacao = Time.time;
        }
    }

    void InvocarInimigo()
    {
        float rdn = Random.Range(Esquerda.x, Direita.x);
        Instantiate(inimigo, new Vector3(rdn , 0 , 46), Quaternion.identity);
    }
}
