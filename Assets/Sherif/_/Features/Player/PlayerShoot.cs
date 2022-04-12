using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    #region Exposed

    [SerializeField]
    private GameObject _bulletPrefab;

    [SerializeField]
    private Transform _cannon;

    [SerializeField]
    private float _bulletSpeed;

    [SerializeField]
    private float _delayBetweenShots;

    [SerializeField]
    private float _delayBeforeDestroy = 1.0f;

    #endregion

    #region Private

    private float _nextShotTime;

    #endregion

    #region Unity API

    private void Awake()
    {
        _nextShotTime = Time.time;
    }

    private void Update()
    {
        if (Input.GetAxisRaw("Shoot") != 0 && Time.time > _nextShotTime + _delayBetweenShots)
        {
            FireBullet();
            _nextShotTime = Time.time;
        }
    }

    #endregion

    #region Main

    private void FireBullet()
    {
        var newBullet = Instantiate(_bulletPrefab, _cannon.position, _cannon.rotation);
        var bullet = newBullet.GetComponent<Bullet>();

        bullet.Shoot(_bulletSpeed);

        Destroy(bullet.gameObject, _delayBeforeDestroy);
    }

    #endregion

    #region Utils
    #endregion

    #region Debug & Tools
    #endregion
}
