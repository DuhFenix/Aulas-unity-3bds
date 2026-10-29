using UnityEngine;

public class Inimigo : MonoBehaviour
{
    float max = 8f;
    float min =  1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        max = max + Bala.pontosValor/2;
        min = min + Bala.pontosValor/2;
    }

    // Update is called once per frame
    void Update()
    {
        float rdn = Random.Range(min, max);
        transform.position += new Vector3(0, 0, -rdn) * Time.deltaTime;
    }

    void OnTriggerEnter(Collider obj)
    {
        if(obj.CompareTag("parede"))
        {
            Destroy(gameObject);
        }
    }
}
