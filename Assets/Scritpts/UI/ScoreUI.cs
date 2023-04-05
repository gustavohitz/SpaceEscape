using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreUI : MonoBehaviour {

    public int score {
        get {
            return _score;
        }
    }

    private int _score;
    [SerializeField]
    private MyEventInt OnScoring;

    public void AddOnePointToScore() {
        _score++;
        OnScoring.Invoke(_score);
    }
    
}

[System.Serializable]
public class MyEventInt : UnityEvent<int> {
    
}
