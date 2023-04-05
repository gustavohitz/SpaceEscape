using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScoreManager : MonoBehaviour {

    [SerializeField]
    private UpdateScoreUI _newScoreTxt;
    private ScoreUI _score;
    [SerializeField]
    private RankingManager _ranking;


    private void Start() {
        _score = GameObject.FindObjectOfType<ScoreUI>();

        var totalPoints = -1;
        if(_score != null) {
            totalPoints = _score.score;
        }

        _newScoreTxt.UpdateScoreTxt(totalPoints);
        _ranking.AddScore(totalPoints);
    }
    
}
