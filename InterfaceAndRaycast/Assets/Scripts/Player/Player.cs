using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMaskToInteract;
    private Rigidbody _rigidbody;
    private PlayerMovement _playerMovement;
    private PlayerRayCast _raycast;
    private bool _canInteract;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _playerMovement = new PlayerMovement(_rigidbody);
        _raycast = new PlayerRayCast(transform, _layerMaskToInteract);
    }

    // Update is called once per frame
    void Update()
    {
        _raycast.ShootRay();
        CheckIfPlayerCanInteract();
    }

    private void CheckIfPlayerCanInteract()
    {
        if (_raycast.CheckIfRayHitAnything())
        {
            AllowInteraction();
        }
    }
    private void AllowInteraction()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            IInteractable gameObjectInteractable = _raycast.GameObjectHadHit.GetComponent<IInteractable>();
            InteractToObject(gameObjectInteractable);
        }
    }
    private void InteractToObject(IInteractable gameObject)
    {
        gameObject.ChangeColor();
    }
    private void FixedUpdate()
    {
        _playerMovement.AllowMove();
    }




}
