using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class uimanager : MonoBehaviour
{
    
    public TMP_Text timer;
    public Image jaugevie;
    public ReceiveDamage rd;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jaugevie.fillAmount = rd.MadeDamage  /rd.maxHitPoint;
        float time = Time.time;
        int minute = Mathf.FloorToInt(time / 60);
        int second = Mathf.FloorToInt(time - minute * 60);
        timer.text = System.String.Format("{0}m {1}s", minute, second);
    }

}
