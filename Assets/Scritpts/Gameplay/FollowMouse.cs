using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

    private void Update() {
        MovePlayer();
    }

    private void MovePlayer() {
        var playerPosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = playerPosition;
        //transformar em Vector2 para ignorar o Z da câmera, pois é um jogo 2D
    }

}
