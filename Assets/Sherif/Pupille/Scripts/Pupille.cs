using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pupille : MonoBehaviour
{
    #region Public

    [SerializeField] private GameObject _target;
    [SerializeField] private GameObject _area;

    #endregion

    #region Private

    Transform _targetTransform;
    Transform _areaTransform;

    #endregion

    #region Unity API

    private void Awake()
    {
        _targetTransform = _target.GetComponent<Transform>();
        _areaTransform = _area.GetComponent<Transform>();
    }

    private void Update()
    {
        MovePosition();
    }

    #endregion

    #region Main

    private void MovePosition()
    {
        Vector2 pupilleToTarget = _targetTransform.position - _areaTransform.position;
        Vector2 pupilleDirection = pupilleToTarget / pupilleToTarget.magnitude;
        Vector2 pupilleRange = Vector2.zero;

        pupilleRange.x = (_areaTransform.localScale.x / 2) - (transform.localScale.x / 2);
        pupilleRange.y = (_areaTransform.localScale.y / 2) - (transform.localScale.y / 2);

        transform.position = (pupilleDirection * pupilleRange);
    }

    #endregion

    #region Utils
    #endregion

    #region Debug & Tools
    #endregion
}
