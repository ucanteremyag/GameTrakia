using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    private float yatayhareket;
    public float harekethizi;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayhareket * harekethizi * Time.deltaTime,rb.velocity.y);
    }
}
