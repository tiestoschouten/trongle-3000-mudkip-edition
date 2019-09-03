using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

    public event Action StrafeLeft, StrafeRight;

    [SerializeField]
    private KeyCode Left;
    [SerializeField]
    private KeyCode Right;
	
	void Update () {
        if (Input.GetKey(Left)) StrafeLeft();
        else if (Input.GetKey(Right)) StrafeRight();
	}
}
