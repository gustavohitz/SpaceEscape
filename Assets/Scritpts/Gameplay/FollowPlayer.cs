using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;

    private void Update() {
        EnemyFollowsPlayer();
    }

    private void EnemyFollowsPlayer() {
        var moving = _target.position - transform.position;
        moving = moving.normalized;
        moving *= _speed;
        transform.position += moving * Time.deltaTime;
    }

    public void SetTarget(Transform newTarget) {
        _target = newTarget;
    }
   
}
