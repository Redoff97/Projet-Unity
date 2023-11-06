using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float sensitivity = 1.5f;
    public float smoothing = 1.5f;

   
    private float xmousespos;
    private float smoothedmousepos;

    private float currentLookingPos;

  
     private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        ModifyInput();
        MovePlayer();
    }
    void GetInput()
    {
        xmousespos = Input.GetAxisRaw("Mouse X");
        Debug.Log(xmousespos);
    }
    void ModifyInput()
    {
        xmousespos *= sensitivity * smoothing;
        smoothedmousepos = Mathf.Lerp(smoothedmousepos, xmousespos, 1f / smoothing);
    }
    void MovePlayer()
    {
        currentLookingPos += smoothedmousepos;
        transform.localRotation = Quaternion.AngleAxis(currentLookingPos, transform.up);
    }

    
    
}
