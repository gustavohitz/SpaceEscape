using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneInstanceManager : MonoBehaviour {

    [SerializeField]
    private bool _overrideExistent;

    private void Start() {
        var otherInstances = GameObject.FindGameObjectsWithTag(this.tag);

        foreach(var instance in otherInstances) {
            if(instance != this.gameObject) {
                if(_overrideExistent) {
                    GameObject.Destroy(instance);
                }
                else {
                    GameObject.Destroy(gameObject);
                }
            }
        }
    }
  
}
