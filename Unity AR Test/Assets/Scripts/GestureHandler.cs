using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureHandler : MonoBehaviour
{
    private Vector3 mousePosition;
    bool mouseDown = false;
    Gesturable targetGesturable;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            mouseDown = true;
            mousePosition = Input.mousePosition;
            Debug.Log("Mouse Down");


            // raycast to whatever the mouse is over while the mouse is down
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                var gesturable = hit.transform.gameObject.GetComponent<Gesturable>();

                // check if the game object being pointed to is a Gesturable object
                if (gesturable != null)
                {
                    targetGesturable = gesturable;
                }
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
            Debug.Log("Mouse Up");
        }


        if (mouseDown)
        {
            // if a Gesturable is currently being dragged over
            if (targetGesturable != null)
            {
                targetGesturable.PerformDragGesture(mousePosition, Input.mousePosition);
            }

            // update the previous mouse position with the current mouse position
            mousePosition = Input.mousePosition;
        }
    }
}
