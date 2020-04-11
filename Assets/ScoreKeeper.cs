
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {
   public int Score;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void IncreamentScore(int value)
    {
        Score = Score + value;
        print("Your score is " + Score);
    }
}
