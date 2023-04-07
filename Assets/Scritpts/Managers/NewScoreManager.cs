using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScoreManager : MonoBehaviour {

    [SerializeField]
    private UpdateScoreUI _newScoreTxt;
    private ScoreUI _score;
    [SerializeField]
    private RankingManager _ranking;
    private int _id;


    private void Start() {
        _score = GameObject.FindObjectOfType<ScoreUI>();

        var totalPoints = -1;
        if(_score != null) {
            totalPoints = _score.score;
        }

        _newScoreTxt.UpdateScoreTxt(totalPoints);
        _id = _ranking.AddScore(totalPoints, "Name");
    }

    public void ChangeName(string name) {
        _ranking.ChangeName(name, _id);
    }
    
}
