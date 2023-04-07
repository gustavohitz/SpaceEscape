using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingPanelUI : MonoBehaviour {

    [SerializeField]
    private RankingManager _ranking;
    [SerializeField]
    private GameObject _hiScorePanelPrefab;

    private void Start() {
        var rankingList = _ranking.GetRankingItems();

        for(var i = 1; i < rankingList.Count; i++) {
            if(i >= 6) {
                break;
            }

            var rankedPlayer = GameObject.Instantiate(_hiScorePanelPrefab, this.transform);
            rankedPlayer.GetComponent<RankingElementsUI>().SetElements(i, rankingList[i].name, rankingList[i].points);
        }
    }
   
}
