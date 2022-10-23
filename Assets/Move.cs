using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float x;
    public float z;

    private void Update()
    {
        InputPlayer();
        
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
   
    public void MovePlayer()
    {
        // addforce truyen luc vector 3
        rb.AddForce(new Vector3(x, 0, z) * speed);

    }

    public void InputPlayer()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}
