using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections.ObjectModel;
using System;

public class RankingManager : MonoBehaviour {

    [SerializeField]
    private List<RankingItems> _rankingList;
    private static string FILE_NAME = "Ranking.json";
    private string _filePath;

    private void Awake() {
        _filePath = Path.Combine(Application.persistentDataPath, FILE_NAME);

        if(File.Exists(_filePath)) {
            var txtJson = File.ReadAllText(_filePath);
            JsonUtility.FromJsonOverwrite(txtJson, this);
        }
        else {
            _rankingList = new List<RankingItems>();
        }
        //Debug.Log(Application.persistentDataPath);
    }

    public int AddScore(int points, string name) {
        var id = _rankingList.Count * UnityEngine.Random.Range(1, 100000);

        var newPlayerElements = new RankingItems(name, points, id);
        _rankingList.Add(newPlayerElements);
        _rankingList.Sort();
        SaveRanking();

        return id;
    }

    public void ChangeName(string newName, int id) {
        foreach(var item in _rankingList) {
            if(item.id == id) {
                item.name = newName;
                break;
            }
        }
        SaveRanking();
    }

    private void SaveRanking() {
        var txtJson = JsonUtility.ToJson(this);
        File.WriteAllText(_filePath, txtJson);
    }

    public int Amount() {
        return _rankingList.Count;
    }

    public ReadOnlyCollection<RankingItems> GetRankingItems() {
        return _rankingList.AsReadOnly();
    }
   
}

[System.Serializable]
public class RankingItems : IComparable {
    public string name;
    public int points;
    public int id;

    public RankingItems(string name, int points, int id) {
        this.name = name;
        this.points = points;
        this.id = id;
    }
    public int CompareTo(object obj) {
        var otherObject = obj as RankingItems;
        return otherObject.points.CompareTo(this.points);
    }
}
