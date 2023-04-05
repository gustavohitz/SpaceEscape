using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreUI : MonoBehaviour {

    public int score { get; private set; }

    [SerializeField]
    private MyEventInt OnScoring;

    public void AddOnePointToScore() {
        score++;
        OnScoring.Invoke(score);
    }
    
}

[System.Serializable]
public class MyEventInt : UnityEvent<int> {
    
}
