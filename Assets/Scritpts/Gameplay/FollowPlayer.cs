using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    [SerializeField]
    private Transform _target;

    private void Update() {
        EnemyFollowsPlayer();
    }

    private void EnemyFollowsPlayer() {
        var moving = _target.position - transform.position;
        moving = moving.normalized;
        transform.position += moving * Time.deltaTime;
    }
   
}
