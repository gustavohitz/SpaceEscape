using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerVolume : MonoBehaviour {

    [SerializeField]
    private AudioMixer _mixer;

    public void ChangeVolume(float volume) {
        _mixer.SetFloat("MusicVolume", volume);
    }
    
}
