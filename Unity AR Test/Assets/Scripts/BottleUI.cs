using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleUI : MonoBehaviour {

    public float rotationRate = 2f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(Vector3.up, rotationRate);
    }
}
