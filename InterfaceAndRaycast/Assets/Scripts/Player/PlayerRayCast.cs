using UnityEngine;

public class PlayerRayCast
{
    private Transform _transform;
    private Ray _ray;
    private RaycastHit _hitData;
    private LayerMask _layerMask;
    public GameObject GameObjectHadHit { get; private set; }

    public PlayerRayCast(Transform transform,  LayerMask layerMask)
    {
        _transform = transform;
        _layerMask = layerMask;
    }

    public void ShootRay()
    {
        _ray = new Ray(_transform.position, _transform.forward);
        Debug.DrawRay(_transform.position, _transform.forward * 10, Color.red);
    }
    public bool CheckIfRayHitAnything()
    {
        if (Physics.Raycast(_ray, out _hitData, 10f, _layerMask))
        {
            GameObjectHadHit = _hitData.transform.gameObject;
            return true;
        }
        return false;
    }
}
