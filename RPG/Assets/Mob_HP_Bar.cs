using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mob_HP_Bar : MonoBehaviour
{
    Slider slHP;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        slHP = GetComponent<Slider>();
        //text = GameObject.Find("Mob1_HP").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.Enemy == "Mob1")
        {
            slHP.value = (float)Mob1_Move.Mob1_HP / Mob1_Move.Mob1_MAXHP;

            if (slHP.value <= 0)
                transform.Find("Fill Area").gameObject.SetActive(false);
            else
                transform.Find("Fill Area").gameObject.SetActive(true);
                
            GameObject.Find("Mob_HP_Text").GetComponent<Text>().text = Mob1_Move.Mob1_HP + "/" + Mob1_Move.Mob1_MAXHP;
        }
    }
}