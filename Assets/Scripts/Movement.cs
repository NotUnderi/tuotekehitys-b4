using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 4.0f;
    public float jump_speed = 5.0f;
    public Vector3 jump;
    public bool grounded;
    public float gravity_scale = 4;
    public GameObject body;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionStay()
    {
        grounded = true;
    }
        // Update is called once per frame
        private void FixedUpdate()
    {
        float inputh = Input.GetAxisRaw("Horizontal"); // Returns 1 when moving right and -1 when moving left
        Vector3 move = transform.right * inputh * speed * Time.deltaTime;

        Quaternion rotation = Quaternion.Euler(0,90*inputh,0);
        body.transform.localRotation = rotation;
    
        rb.MovePosition(transform.position + move);
        rb.AddForce(Physics.gravity * gravity_scale * rb.mass);
    
        if (Input.GetAxisRaw("Vertical")==1 && grounded) {
            rb.AddForce(jump * jump_speed, ForceMode.Impulse);
            grounded = false;
        }



    }
}
