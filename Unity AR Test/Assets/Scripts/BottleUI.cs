using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleUI : Gesturable {

    public float rotationRate = 2f;

    public override void PerformDragGesture(Vector3 initialPosition, Vector3 finalPosition)
    {

        // the rotation amount is derived using the dot product, which is zero when two vectors are
        // exactly perpendicular and ranges between -1 and 1 in other cases
        float rotationAmount = Vector3.Dot(transform.up, finalPosition - initialPosition);

        transform.Rotate(Vector3.up, rotationAmount);
    }

    public override void PerformSwipeGesture(Vector3 velocity)
    {
        throw new System.NotImplementedException();
    }



    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        //transform.Rotate(Vector3.up, rotationRate);
    }
}
