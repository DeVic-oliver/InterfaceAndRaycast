using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour, IInteractable
{
    private MeshRenderer _meshRenderer;
    [SerializeField] private Color _color;
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        _meshRenderer.material.SetColor("_Color", _color);
    }
}
