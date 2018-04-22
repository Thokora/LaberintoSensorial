using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistaScript : MonoBehaviour {

    Movimiento movScript;
    public GameObject pista;
    public GameObject player;
    float ValorRot;

	void Start () {
		
	}
	
	void Update () {

        pista.transform.position = 
            new Vector3(player.transform.position.x, player.transform.position.y, (player.transform.position.z));

        ValorRot = player.transform.eulerAngles.y;
        pista.transform.eulerAngles = new Vector3(0, ValorRot, 0);

    }
}
