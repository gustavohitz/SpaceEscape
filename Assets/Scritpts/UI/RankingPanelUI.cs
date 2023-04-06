using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingPanelUI : MonoBehaviour {

    [SerializeField]
    private RankingManager _ranking;
    [SerializeField]
    private GameObject _hiScorePanelPrefab;

    private void Start() {
        var scoreList = _ranking.GetPoints();

        for(var i = 1; i < scoreList.Count; i++) {
            if(i >= 6) {
                break;
            }

            var rankedPlayer = GameObject.Instantiate(_hiScorePanelPrefab, this.transform);
            rankedPlayer.GetComponent<RankingElementsUI>().SetElements(i, "Piruca", scoreList[i]);
        }
    }
   
}
