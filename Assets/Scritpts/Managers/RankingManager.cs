using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RankingManager : MonoBehaviour {

    [SerializeField]
    private List<int> _points;
    private static string FILE_NAME = "Ranking.json";

    private void Awake() {
        _points = new List<int>();
    }

    public void AddScore(int points) {
        _points.Add(points);
        SaveRanking();
    }

    private void SaveRanking() {
        var txtJson = JsonUtility.ToJson(this);
        var filePath = Path.Combine(Application.persistentDataPath, FILE_NAME);
        File.WriteAllText(filePath, txtJson);
    }
   
}
