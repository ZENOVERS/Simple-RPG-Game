using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float P_HP;
    public static int P_MAXHP;
    public static int P_Level;
    public static int P_Exp;
    public static int P_ATK;
    public static int P_DEF;


    // Start is called before the first frame update
    void Start()
    {
        P_HP = Information.P_HP;
        P_MAXHP = Information.P_MAXHP;
        P_Level = Information.P_Level;
        P_Exp = Information.P_Exp;
        P_DEF = Information.P_DEF;
        P_ATK = Information.P_ATK;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D other) 
    {
        if (other.gameObject.tag.Equals("Mob1"))
        {
            P_HP -= Information.Mob1_ATK;
        }
    }
}
