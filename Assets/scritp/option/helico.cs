using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class helico : MonoBehaviour
{
    public string nomdunivsuivant;



    private void Nextlv()
    {
         SceneManager.LoadScene(nomdunivsuivant);
    }
    private void OnTriggerEntrer(Collider Other)

    {
        Nextlv();
    }

}