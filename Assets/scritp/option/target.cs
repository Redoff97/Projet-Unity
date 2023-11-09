using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class target: MonoBehaviour
{
    public float cubetoucher;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.gameObject.CompareTag("CUBE"))
            {
                cubetoucher += 1;
            }
            if (cubetoucher >= 4)
                SceneManager.LoadScene(1);
        
    }
    
}
