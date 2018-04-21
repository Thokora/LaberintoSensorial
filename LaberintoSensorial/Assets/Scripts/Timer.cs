using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text TimeText;
    float starTime;
    float T;
    string Minutes;
    string Seconds;
    bool finished = false;

	void Start () {
        starTime = Time.time;
	}
	

	void Update () {
        if (finished)
            return; // si se pone en true, no ejecute lo que hay de aca para abajo

        T = Time.time - starTime;
        Minutes = ((int)T / 60).ToString();
        Seconds = ((T % 60)).ToString("f0"); //"f2" si se quiere ver los milisegundos
        TimeText.text = Minutes + ":" + Seconds;
	}
    public void Finish()
    {
        finished = true;
        TimeText.color = Color.yellow;
    }
}
