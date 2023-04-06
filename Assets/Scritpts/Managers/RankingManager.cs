using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections.ObjectModel;

public class RankingManager : MonoBehaviour {

    [SerializeField]
    private List<int> _points;
    private static string FILE_NAME = "Ranking.json";
    private string _filePath;

    private void Awake() {
        _filePath = Path.Combine(Application.persistentDataPath, FILE_NAME);
        var txtJson = File.ReadAllText(_filePath);
        JsonUtility.FromJsonOverwrite(txtJson, this);
    }

    public void AddScore(int points) {
        _points.Add(points);
        SaveRanking();
    }

    private void SaveRanking() {
        var txtJson = JsonUtility.ToJson(this);
        File.WriteAllText(_filePath, txtJson);
    }

    public int Amount() {
        return _points.Count;
    }

    public ReadOnlyCollection<int> GetPoints() {
        return _points.AsReadOnly();
    }
   
}
