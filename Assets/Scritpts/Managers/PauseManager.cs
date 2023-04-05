using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {

    [SerializeField]
    private GameObject _pausePanel;
    [SerializeField, Range(0,1)]
    private float _timeScaleDuringPause;
    private bool _isPaused;

    private void Update() {
        PauseOrNot();
    }

    private void Unpause() {
        StartCoroutine(WaitAndContinueGame());
    }

    private IEnumerator WaitAndContinueGame() {
        yield return new WaitForSecondsRealtime(0.2f);

        _pausePanel.SetActive(false);
        ChangeTimeScale(1);
        _isPaused = false;
    }

    private void Pause() {
        _pausePanel.SetActive(true);
        ChangeTimeScale(_timeScaleDuringPause);
        _isPaused = true;
    }

    private bool IsTouchingScreen() {
        return Input.touchCount > 0;
    }

    private void PauseOrNot() {
        if(IsTouchingScreen()) {
            if(_isPaused) {
                Unpause();
            }
        }
        else {
            if(!_isPaused) {
                Pause();
            }
        }
    }



    private void ChangeTimeScale(float scale) {
        Time.timeScale = scale;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
    
}
