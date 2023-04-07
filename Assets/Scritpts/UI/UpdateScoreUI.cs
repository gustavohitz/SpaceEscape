using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreUI : MonoBehaviour {

    private Text _scoreTxt;

    private void Awake() {
        _scoreTxt = GetComponent<Text>();
    }

    public void UpdateScoreTxt(int number) {
        _scoreTxt.text = number.ToString();
    }
    public void UpdateScoreTxt(string newText) {
        _scoreTxt.text = newText;
    }
 
}
