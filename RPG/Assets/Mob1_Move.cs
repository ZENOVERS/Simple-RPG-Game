using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1_Move : MonoBehaviour
{
    public static int Mob1_HP;
    public static int Mob1_MAXHP;
    //public static Transform Mob1_Location;
    void Start()
    {
        Mob1_MAXHP = Information.Mob1_MAXHP;
        Mob1_HP = Information.Mob1_HP; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Information.Mob1_Speed * Time.deltaTime;
        //Mob1_Location = this.transform;
    }

    void OnCollisionStay2D(Collision2D other) 
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Mob1_HP -= Player.P_ATK;

            if (Mob1_HP <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
