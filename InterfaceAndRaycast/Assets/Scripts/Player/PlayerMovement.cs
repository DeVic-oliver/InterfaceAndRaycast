using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    private Rigidbody _rigidbody;
    private float speed = 5f;
    public PlayerMovement(Rigidbody rigidbody)
    {
        _rigidbody = rigidbody;
    }
    
    public void AllowMove()
    {
        if (Input.GetKey(KeyCode.W)){
            MoveToPosition(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveToPosition(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveToPosition(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveToPosition(Vector3.right);
        }

    }
    private void MoveToPosition(Vector3 position)
    {
        _rigidbody.MovePosition(_rigidbody.position + (position * speed) * Time.deltaTime);
    }
}
