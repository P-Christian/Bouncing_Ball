using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counterText : MonoBehaviour {

    public Text myText;
    private int counter;
    void Start() {
        myText.text = "";
    }

    // Update is called once per frame
    void Update() {
        myText.text = "Bounce Count : " + counter;
    }

    private void OnTriggerEnter(Collider other) {
        counter++;
    }
}
