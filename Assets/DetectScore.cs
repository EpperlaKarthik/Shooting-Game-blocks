using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScore : MonoBehaviour {
    public int Value;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
       ScoreKeeper scorekeeper= FindObjectOfType<ScoreKeeper>();
        scorekeeper.IncreamentScore(Value);
    }
}
