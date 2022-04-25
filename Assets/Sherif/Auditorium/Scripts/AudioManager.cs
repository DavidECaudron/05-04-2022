using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region Public

    [SerializeField]
    private List<AudioSource> _listAudioSource = new List<AudioSource>();

    #endregion

    #region Private
    #endregion

    #region Unity API

    private void Awake()
    {
        AudioSource temp;
        foreach (Transform item in transform)
        {
            temp = item.GetComponent<AudioSource>();
            _listAudioSource.Add(temp);
            temp.Play();
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
