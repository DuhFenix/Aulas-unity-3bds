using UnityEngine;
using UnityEngine.InputSystem;

public class Movimentar : MonoBehaviour
{
    private Rigidbody rg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rg.linearVelocity = new Vector3(horizontal * 2f , 0 ,vertical * 2f);
    }



}
