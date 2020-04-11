using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    ScoreKeeper scorekeeper;
    Text text;
    // Use this for initialization
    void Start () {
        scorekeeper = FindObjectOfType<ScoreKeeper>();
         text = GetComponent<Text>();
       

    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Score: "+scorekeeper.Score;
    }
}
