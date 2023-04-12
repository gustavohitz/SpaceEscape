using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScoreManager : MonoBehaviour {

    [SerializeField]
    private UpdateScoreUI _newScoreTxt;
    [SerializeField]
    private UpdateScoreUI _newNameTxt;
    private ScoreUI _score;
    [SerializeField]
    private RankingManager _ranking;
    private string _id;


    private void Start() {
        int totalPoints = GetScore();
        string playerName = GetName();
        _newScoreTxt.UpdateScoreTxt(totalPoints);
        _newNameTxt.UpdateScoreTxt(playerName);
        _id = _ranking.AddScore(totalPoints, playerName);
    }

    private string GetName() {
        if(PlayerPrefs.HasKey("LastName")) {
            return PlayerPrefs.GetString("LastName");
        }
        return "Name";
    }

    private int GetScore() {
        _score = GameObject.FindObjectOfType<ScoreUI>();

        var totalPoints = -1;
        if (_score != null) {
            totalPoints = _score.score;
        }

        return totalPoints;
    }

    public void ChangeName(string name) {
        _ranking.ChangeName(name, _id);
        PlayerPrefs.SetString("LastName", name);
    }
    
}
