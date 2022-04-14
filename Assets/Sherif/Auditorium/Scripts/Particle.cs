using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    #region Public
    #endregion

    #region Public

    private Rigidbody2D _particleRigidbody;

    #endregion

    #region Unity API

    private void Awake()
    {
        _particleRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_particleRigidbody.velocity == Vector2.zero)
        {
            Destroy(gameObject);
        }
    }

    #endregion

    #region Main
    #endregion

    #region Utils
    #endregion

    #region Debug & Tools
    #endregion
}
