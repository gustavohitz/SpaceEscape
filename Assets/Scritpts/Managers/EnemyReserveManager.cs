using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReserveManager : MonoBehaviour {

    private EnemyReserve _myReserve;

    public void PutEnemyBack() {
        _myReserve.PutEnemyBackInTheReserve(this.gameObject);
    }

    public void SetReserve(EnemyReserve reserve) {
        _myReserve = reserve;
    }
    
}
