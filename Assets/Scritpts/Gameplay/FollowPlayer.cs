using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _force;
    private Rigidbody2D _rb2d;

    private void Awake() {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        EnemyFollowsPlayer();
    }

    private void EnemyFollowsPlayer() {
        var moving = _target.position - transform.position;
        moving = moving.normalized;
        moving *= _force;
        _rb2d.AddForce(moving, ForceMode2D.Force);
    }

    public void SetTarget(Transform newTarget) {
        _target = newTarget;
    }
   
}
