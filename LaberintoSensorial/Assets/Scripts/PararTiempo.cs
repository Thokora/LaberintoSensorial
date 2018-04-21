using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PararTiempo : MonoBehaviour {

    public string Player = "Player";
    Timer timerScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Player)
        {
            GameObject.Find("Master").SendMessage("Finish");
        }
    }
}
