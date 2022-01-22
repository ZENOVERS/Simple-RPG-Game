using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
 
public class HP_Bar : MonoBehaviour
{
    Slider slHP;
    Text text;

    float P_HP;
    float P_MAXHP;

    void Start()
    {
       slHP = GetComponent<Slider>();
       text = GameObject.Find("HP").GetComponent<Text>();
    }
 
    void Update()
    {
        P_HP = Player.P_HP; 
        P_MAXHP = Player.P_MAXHP;

        slHP.value = P_HP / P_MAXHP;

        text.text = P_HP + "/" + P_MAXHP;

        if (slHP.value <= 0)
            transform.Find("Fill Area").gameObject.SetActive(false);
        else
            transform.Find("Fill Area").gameObject.SetActive(true);
    }
}
