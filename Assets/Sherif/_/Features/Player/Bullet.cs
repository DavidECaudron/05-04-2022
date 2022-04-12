using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region Exposed
    #endregion

    #region Private

    private float _bulletSpeed;

    private Rigidbody _bulletRigidbody;
    private Transform _bulletTransform;

    #endregion

    #region Unity API

    private void Awake()
    {
        _bulletRigidbody = GetComponent<Rigidbody>();
        _bulletTransform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        var velocity = _bulletTransform.forward * _bulletSpeed;
        var movementStep = velocity * Time.fixedDeltaTime;

        var newPos = _bulletTransform.position + movementStep;

        _bulletRigidbody.MovePosition(newPos);
    }

    #endregion

    #region Main

    public void Shoot(float speed)
    {
        _bulletSpeed = speed;
    }

    #endregion

    #region Utils
    #endregion

    #region Debug & Tools
    #endregion
}
