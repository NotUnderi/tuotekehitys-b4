using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    AudioSource jumpSound;
    public float speed = 4.0f;
    public float jump_speed = 5.0f;
    public Vector3 jump;
    public bool grounded;
    public float gravity_scale = 4;
    public GameObject body;
    public GameObject feet;
    public float dash_height;
    public float dash_speed;

    private bool i_jump;
    private bool i_dash;

    private float lastPressed;
    private float d_lastPressed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpSound = GetComponent<AudioSource>();
    }

    private void Update()
    {

        
        //if () { i_dash = true; };
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        float inputh = Input.GetAxisRaw("Horizontal"); // Returns 1 when moving right and -1 when moving left
        Vector3 move = transform.right * inputh * speed * Time.deltaTime;
        // 0 vas, -90 keski, 180 oikea
        Quaternion rotation = Quaternion.Euler(0,90*inputh*-1,0);
        body.transform.localRotation = rotation;
    
        rb.MovePosition(transform.position + move);
        rb.AddForce(Physics.gravity * gravity_scale * rb.mass);
        //bug.Log(Time.fixedTime);
        Collider groundCheck = Physics.OverlapSphere(feet.transform.position,0.5f,LayerMask.GetMask("Ground"))[0];
        if (groundCheck != null) grounded = true;

        if (Input.GetAxisRaw("Vertical") == 1 && grounded && lastPressed + 0.3f < Time.fixedTime) { 
            rb.AddForce(jump * jump_speed, ForceMode.Impulse);
            grounded = false;
            jumpSound.Play();
            lastPressed = Time.fixedTime;
            Debug.Log("Jump");
        }
        if (Input.GetKey("space") && d_lastPressed + 1.0f < Time.fixedTime)
        {
            Debug.Log("Dash");
            rb.AddForce(new Vector3(5.0f * inputh, dash_height, 0.0f) * dash_speed, ForceMode.Impulse);

            d_lastPressed = Time.fixedTime;
            i_dash = false;
        }


    }
}
