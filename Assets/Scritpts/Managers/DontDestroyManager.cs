using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyManager : MonoBehaviour {

    private void Start() {
        GameObject.DontDestroyOnLoad(gameObject);
    }
    
}
