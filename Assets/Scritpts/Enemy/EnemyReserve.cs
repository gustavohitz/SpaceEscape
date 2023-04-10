using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReserve : MonoBehaviour {

    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private int _amountOfEnemiesCreated;

    private Stack<GameObject> _enemyReserve; //vamos criar uma pilha de inimigos e colocar numa reserva

    private void Start() {
        _enemyReserve = new Stack<GameObject>();
    }

    private void CreateAllEnemies() {
        for(var i = 0; i < _amountOfEnemiesCreated; i++) {
            var enemy = GameObject.Instantiate(_enemyPrefab, this.transform);
            enemy.SetActive(false);
            _enemyReserve.Push(enemy);
        }
    }
    
}
