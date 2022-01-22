using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Mob1_OnOff : MonoBehaviour
{
    public void OnClik(bool state)
    {
        GameObject.FindWithTag("M1G").GetComponent<Mob1>().enabled = state;

        GameObject M1Button = GameObject.Find("M1");
        M1Button.GetComponent<Button>().interactable = !state; //현재 스테이지 버튼을 흐리게
    }
}