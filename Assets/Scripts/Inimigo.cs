using UnityEngine;

public class Inimigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rdn = Random.Range(1, 8);
        transform.position += new Vector3(0, 0, -rdn) * Time.deltaTime;
    }
}
