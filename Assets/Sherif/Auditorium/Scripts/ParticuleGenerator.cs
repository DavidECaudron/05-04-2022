using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticuleGenerator : MonoBehaviour
{
    #region Public

    [SerializeField] private float _spawnSize;
    [SerializeField] private float _waitForSpawn;

    [SerializeField] private GameObject _particlePrefab;
    [SerializeField] private Vector2 _particleCloneDirection;
    [SerializeField] private float _particleCloneVelocity;
    [SerializeField] private float _particleCloneDrag;
    [SerializeField] private float _particleCloneDirectionAngle;

    #endregion

    #region Private

    private Transform thisTransform;

    #endregion

    #region Unity API

    private void Awake()
    {
        thisTransform = gameObject.GetComponent<Transform>();
    }

    private void Start()
    {
        StartCoroutine(ParticleGeneration());
    }

    #endregion

    #region Main
    #endregion

    #region Utils

    IEnumerator ParticleGeneration()
    {
        while (true)
        {
            GameObject particleClone =  Instantiate(_particlePrefab,thisTransform.position = Random.insideUnitCircle * _spawnSize, thisTransform.rotation);

            Rigidbody2D particleCloneRigidbody = particleClone.GetComponent<Rigidbody2D>();
            Transform particleCloneTransform = particleClone.GetComponent<Transform>();

            particleCloneTransform.Rotate(0.0f, 0.0f, _particleCloneDirectionAngle);
            particleCloneRigidbody.velocity = particleCloneTransform.up * _particleCloneVelocity;
            particleCloneRigidbody.drag = _particleCloneDrag;

            yield return new WaitForSeconds(_waitForSpawn);
        }
    }

    #endregion

    #region Debug & Tools
    #endregion
}
