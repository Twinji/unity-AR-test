using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Gesturable : MonoBehaviour
{
    public abstract void PerformDragGesture(Vector3 initialPosition, Vector3 finalPosition);
    public abstract void PerformSwipeGesture(Vector3 velocity);
}
