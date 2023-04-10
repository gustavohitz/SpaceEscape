using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gerador : MonoBehaviour
{
    
    [SerializeField]
    private float tempo;
    [SerializeField]
    private float raio;
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private ScoreUI _score;

    [SerializeField]
    private EnemyReserve _enemyReserve;

    private void Start() {
        InvokeRepeating("Instanciar", 1f, tempo);
    }


    private void Instanciar() {
        if(_enemyReserve.AreThereEnemiesInTheReserve()) {
            var inimigo = _enemyReserve.GetEnemy();
            inimigo.SetActive(true);
            this.DefinirPosicaoInimigo(inimigo);
            inimigo.GetComponent<FollowPlayer>().SetTarget(_target);
            inimigo.GetComponent<ScoreManager>().SetScore(_score);
        }
    }

    private void DefinirPosicaoInimigo(GameObject inimigo) {
        var posicaoAleatoria = new Vector3(Random.Range(-this.raio, this.raio),
                        Random.Range(-this.raio, this.raio),
                        0);

        var posicaoInimigo = this.transform.position + posicaoAleatoria;
        inimigo.transform.position = posicaoInimigo;
    }
}
