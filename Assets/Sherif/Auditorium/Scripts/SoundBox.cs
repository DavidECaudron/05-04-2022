using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBox : MonoBehaviour
{
    #region Public

    [SerializeField] private float _volumeDownTimer;
    [SerializeField] private Material _materialOn;
    [SerializeField] private Material _materialOff;

    #endregion

    #region Private

    private AudioSource _audioSource;
    private List<Renderer> _listRenderer = new List<Renderer>();
    private float _triggerEnterTime;

    #endregion

    #region Unity API

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = 0.0f;

        Renderer temp;
        foreach (Transform item in transform)
        {
            temp = item.GetComponent<Renderer>();
            _listRenderer.Add(temp);
        }
    }

    private void Update()
    {
        MaterialOff();
        MaterialOn();

        float temp = Time.time;
        if (temp - _triggerEnterTime >= _volumeDownTimer)
        {
            _audioSource.volume -= 1.0f / _listRenderer.Count;
            _triggerEnterTime = Time.time;
        }
    }

    #endregion

    #region Main

    private void MaterialOff()
    {
        foreach (var item in _listRenderer)
        {
            item.material = _materialOff;
        }
    }

    private void MaterialOn()
    {
        float round = Mathf.Round(_audioSource.volume * _listRenderer.Count);

        for (int i = 0; i < round; i++)
        {
            _listRenderer[i].material = _materialOn;
        }
    }

    #endregion

    #region Utils

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _audioSource.volume += 1.0f / _listRenderer.Count;
        _triggerEnterTime = Time.time;
    }

    #endregion

    #region Debug & Tools
    #endregion
}
