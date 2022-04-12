using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    #region Exposed

    [SerializeField]
    private Transform _playerTransform;

    [SerializeField]
    private float _rotationSpeed = 0.5f;

    [SerializeField]
    private float _moveSpeed = 5.0f;

    #endregion
    #region Private

    private Transform _enemytransform;
    private Rigidbody _enemyRigidbody;

    #endregion
    #region Unity API

    private void Awake()
    {
        _enemytransform = GetComponent<Transform>();
        _enemyRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        TurnTowardsPlayer();
    }

    #endregion
    #region Main

    private void TurnTowardsPlayer()
    {
        Vector3 playerPosition = _playerTransform.position;
        Vector3 enemyPosition = _enemytransform.position;

        Vector3 direction = (playerPosition - enemyPosition).normalized;

        Quaternion lookRotation = Quaternion.LookRotation(direction);

        Quaternion rotateTowards = Quaternion.RotateTowards(_enemytransform.rotation, lookRotation, _rotationSpeed * Time.deltaTime);

        _enemyRigidbody.MoveRotation(rotateTowards);

        _enemyRigidbody.velocity = _enemytransform.forward * _moveSpeed;
    }

    #endregion
    #region Utils
    #endregion
    #region Debug & tools
    #endregion
}
