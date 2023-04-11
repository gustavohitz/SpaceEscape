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
        CreateAllEnemies();
    }

    private void CreateAllEnemies() {
        for(var i = 0; i < _amountOfEnemiesCreated; i++) {
            var enemy = GameObject.Instantiate(_enemyPrefab, this.transform);
            var reserveEnemy = enemy.GetComponent<EnemyReserveManager>();
            reserveEnemy.SetReserve(this);
            enemy.SetActive(false);
            _enemyReserve.Push(enemy);
        }
    }

    public GameObject GetEnemy() {
        var enemy = _enemyReserve.Pop();
        enemy.SetActive(true);
        return enemy;
    }

    public void PutEnemyBackInTheReserve(GameObject enemy) {
        enemy.SetActive(false);
        _enemyReserve.Push(enemy);
    }

    public bool AreThereEnemiesInTheReserve() {
        return _enemyReserve.Count > 0;
    }
    
}
