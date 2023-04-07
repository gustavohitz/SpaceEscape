using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneInstanceManager : MonoBehaviour {

    private void Start() {
        var otherInstances = GameObject.FindGameObjectsWithTag(this.tag);

        foreach(var instance in otherInstances) {
            if(instance != this.gameObject) {
                GameObject.Destroy(instance.gameObject);
            }
        }
    }
  
}
