using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingMove : MonoBehaviour {

    private Vector3 _initialPosition;

    [SerializeField]
    private float _amplitude;
    [SerializeField]
    private float _speed;
    private float _angle;

    private void Awake() {
        _initialPosition = transform.position;
    }

    private void Update() {
        CreatingSwingingMove();
    }

    private void CreatingSwingingMove() {
        _angle += _speed * Time.deltaTime;
        var variation = Mathf.Sin(_angle);
        transform.position = _initialPosition + (_amplitude * variation * Vector3.up);
    }
    
}
