using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1 : MonoBehaviour
{
    public GameObject Mob;

    public float tiemr = 0.8f;

    // Update is called once per frame
    void Update()
    {
        tiemr += Time.deltaTime;

        while (tiemr > 0.7f)
        {
            GameObject newMob = Instantiate(Mob);
            newMob.transform.position = new Vector3(3.5f, -4.121294f, 0);
            tiemr = 0;
        } 
    }
}