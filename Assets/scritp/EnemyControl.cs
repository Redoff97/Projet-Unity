using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public int health = 3;
    public float PlayerRange = 10f;
    public float Movespeed;
    public Transform target;
    private Rigidbody rigi;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        Vector3 dir = (target.position - transform.position).normalized;
        dir.y = 0;
        rigi.velocity = dir.normalized * Movespeed;
    }
    public void TakeDamage()
    {
        health--;
        if (health <= 0)
        { 
            Destroy(gameObject);
        }
    }


}
