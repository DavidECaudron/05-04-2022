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

    #endregion
    #region Private

    private Transform _enemytransform;

    #endregion
    #region Unity API

    private void Awake()
    {
        _enemytransform = GetComponent<Transform>();
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

        _enemytransform.rotation = Quaternion.LookRotation(direction);

        _enemytransform.rotation = Quaternion.RotateTowards(_enemytransform.rotation, _playerTransform.rotation, _rotationSpeed * Time.deltaTime);
    }

    #endregion
    #region Utils
    #endregion
    #region Debug & tools
    #endregion
}
