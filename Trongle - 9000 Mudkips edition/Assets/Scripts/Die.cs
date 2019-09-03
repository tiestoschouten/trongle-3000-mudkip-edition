using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        Time.timeScale = 0;
    }
}
