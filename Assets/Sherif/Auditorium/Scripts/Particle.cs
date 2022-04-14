using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    #region Public
    #endregion

    #region Private

    private TrailRenderer _particleTrailRenderer;

    #endregion

    #region Unity API

    private void Awake()
    {
        _particleTrailRenderer = GetComponent<TrailRenderer>();
    }

    private void Start()
    {
        _particleTrailRenderer.autodestruct = true;
        _particleTrailRenderer.time = 2.5f;
    }

    #endregion

    #region Main
    #endregion

    #region Utils
    #endregion

    #region Debug & Tools
    #endregion
}
