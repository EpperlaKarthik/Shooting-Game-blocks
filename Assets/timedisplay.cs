using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timedisplay : MonoBehaviour {
    Scenemanager scenemanager;
    Text timetext;
    
	// Use this for initialization
	void Start () {

        scenemanager = FindObjectOfType<Scenemanager>();
        timetext = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        timetext.text = "Time: " + scenemanager.time;
	}
}
