using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private PlayerMovement _playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _playerMovement = new PlayerMovement(_rigidbody);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            IInteractable gameObject = GameObject.FindGameObjectWithTag("Interactable").GetComponent<IInteractable>();
            InteractToObject(gameObject);
        }
    }
    private void FixedUpdate()
    {
        _playerMovement.AllowMove();
    }

    public void InteractToObject(IInteractable gameObject)
    {
        
            gameObject.ChangeColor();
    }
}
