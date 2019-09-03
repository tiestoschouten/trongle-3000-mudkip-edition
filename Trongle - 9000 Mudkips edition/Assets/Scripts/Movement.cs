using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody Body;
    private Vector3 Direction;

    [SerializeField]
    private float MovementSpeed;
    [SerializeField]
    private float TurnSpeed;
    private float Rotation = 0;

    void Start()
    {
        Body = GetComponent<Rigidbody>();
        

        GetComponent<InputHandler>().StrafeLeft += MoveLeft;
        GetComponent<InputHandler>().StrafeRight += MoveRight;
    }

    private void FixedUpdate()
    {
        Direction = new Vector3(Mathf.Sin(Rotation * Mathf.PI / 180), 0, Mathf.Cos(Rotation * Mathf.PI / 180));
        Body.velocity = Direction * (MovementSpeed * Time.deltaTime);
    }

    private void MoveLeft() {
        transform.Rotate(0, -TurnSpeed * Time.deltaTime , 0);
        Rotation -= TurnSpeed * Time.deltaTime;
    }

    private void MoveRight()
    {
        transform.Rotate(0, +TurnSpeed * Time.deltaTime, 0);
        Rotation += TurnSpeed * Time.deltaTime;
    }
}
