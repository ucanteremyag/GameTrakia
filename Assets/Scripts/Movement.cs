using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    private float yatayhareket;
    public float harekethizi;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
       
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayhareket * harekethizi * Time.deltaTime,rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
