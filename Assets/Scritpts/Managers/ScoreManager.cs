using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private ScoreUI _score;

    public void ComputeScore() {
        _score.AddOnePointToScore();
    }
    public void SetScore(ScoreUI score) {
        _score = score;
    }
   
}
