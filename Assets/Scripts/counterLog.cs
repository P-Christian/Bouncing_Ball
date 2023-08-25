using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counterLog : MonoBehaviour {

    public int counter = 0;
    private void OnTriggerEnter(Collider other) {
        Debug.Log(counter++);
    }
}
