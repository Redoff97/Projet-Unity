using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermov : MonoBehaviour
{
    public float vitesse;
    public float jumpForce;
    private Rigidbody rigi;
    private Vector3 velocity;



    private float timer = -1;



    public Transform visuelPersonnage;
    public Transform camTransform;




    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // -1 1
        float vertical = Input.GetAxisRaw("Vertical"); // -1 1 
        velocity = camTransform.right * horizontal + camTransform.forward * vertical;
        velocity = velocity.normalized * vitesse;

        Debug.Log(IsOnTheGround());

        if (Input.GetButtonDown("Jump") && IsOnTheGround())
        {
            rigi.AddForce(Vector3.up * jumpForce);
            timer = .2f;
        }
        timer -= Time.deltaTime;



        if (rigi.velocity.magnitude > .1f && Mathf.Abs(rigi.velocity.y) < .1f)
            visuelPersonnage.forward = rigi.velocity;
    }



    private void FixedUpdate()
    {
        if (IsOnTheGround())
            rigi.velocity = velocity;
    }



    public bool IsOnTheGround()
    {
        return (Physics.Raycast(transform.position + Vector3.up * 0.2F, Vector3.down, 2) && timer < 0);
    }
}


