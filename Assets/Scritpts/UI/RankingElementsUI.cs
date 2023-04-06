using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingElementsUI : MonoBehaviour {

    [SerializeField]
    private Text _positionTxt;
    [SerializeField]
    private Text _nameTxt;
    [SerializeField]
    private Text _scoreTxt;

    public void SetElements(int position, string name, int score) {
        _positionTxt.text = position.ToString();
        _nameTxt.text = name;
        _scoreTxt.text = score.ToString();
    }
   
}
