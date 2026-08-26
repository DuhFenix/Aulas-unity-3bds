using UnityEngine;
using UnityEngine.InputSystem;

public class cubo : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bala;
    public GameObject pontoTiro;
    private Rigidbody rg;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");

        if (Keyboard.current.dKey.isPressed)
        {
            rg.linearVelocity = new Vector3(speed, 0, 0);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            rg.linearVelocity = new Vector3(-speed, 0, 0);
        }

        if (Keyboard.current.spaceKey.isPressed)
        {
            Instantiate(bala, pontoTiro.transform.position, pontoTiro.transform.rotation);
        }
    }
}
