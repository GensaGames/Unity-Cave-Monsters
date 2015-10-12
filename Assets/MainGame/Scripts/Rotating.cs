using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {

    public float stepRotating = 2.0f;

    private float timeDelay = 3.0f;
	void Start () {
	
        Invoke("StopRotating", timeDelay);
	}
	
	void Update () {
        Vector3 euler = transform.localEulerAngles;
        euler.z += stepRotating;
        transform.localEulerAngles = euler;

	}

    private void StopRotating() {
        stepRotating = 0.0f;
    }
}
