using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerVolume : MonoBehaviour {

    [SerializeField]
    private AudioMixer _mixer;
    [SerializeField]
    private string _mixerParameter;

    private void Start() {
        if(PlayerPrefs.HasKey(_mixerParameter)) {
            _mixer.SetFloat(_mixerParameter, PlayerPrefs.GetFloat(_mixerParameter));
        }
        else {
            _mixer.SetFloat(_mixerParameter, 0);
        }
    }

    public void ChangeVolume(float volume) {
        _mixer.SetFloat(_mixerParameter, volume);
        PlayerPrefs.SetFloat(_mixerParameter, volume);
    }
    
}
