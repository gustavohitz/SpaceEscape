using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gerador : MonoBehaviour
{
    
    [SerializeField]
    private float tempo;
    [SerializeField]
    private Rect _generateArea;
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
            this.DefinirPosicaoInimigo(inimigo);
            inimigo.GetComponent<FollowPlayer>().SetTarget(_target);
            inimigo.GetComponent<ScoreManager>().SetScore(_score);
        }
    }

    private void DefinirPosicaoInimigo(GameObject inimigo) {
        var posicaoAleatoria = new Vector2(Random.Range(_generateArea.x, _generateArea.x + _generateArea.width), Random.Range(_generateArea.y, _generateArea.y + _generateArea.height));
        var posicaoInimigo = (Vector2)this.transform.position + posicaoAleatoria;
        inimigo.transform.position = posicaoInimigo;
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = new Color(100, 0, 199);
        var position = _generateArea.position + (Vector2)transform.position + _generateArea.size/2;
        Gizmos.DrawWireCube(position, _generateArea.size);
    }
}
