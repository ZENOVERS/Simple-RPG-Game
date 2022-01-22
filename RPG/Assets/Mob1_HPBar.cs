using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mob1_HPBar : MonoBehaviour
{
    Slider slHP;
    Text text;
    public static int Mob1_HP;
    public static int Mob1_MAXHP;
    

    // Start is called before the first frame update
    void Start()
    {
        slHP = GameObject.Find("Slider").GetComponent<Slider>();
        Mob1_HP = Information.Mob1_HP;
        Mob1_MAXHP = Information.Mob1_MAXHP;
        text = GameObject.Find("Mob1_HP").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform != null && text != null)
        {
            //transform.position = Mob1_Move.Mob1_Location.position;
            transform.position = Camera.main.WorldToScreenPoint(Mob1_Move.Mob1_Location.position + new Vector3(0, 0.8f, 0));
            slHP.value = Mob1_HP / Mob1_MAXHP;
            text.text = Mob1_HP + "/" + Mob1_MAXHP;
        }
    }
}
