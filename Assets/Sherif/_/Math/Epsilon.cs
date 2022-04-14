using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epsilon : MonoBehaviour
{
    private void Start()
    {
        float life = 0.2f;
        Debug.Log(Mathf.Epsilon);

        if (Mathf.Abs(life - 0.2f) < Mathf.Epsilon)
        {

        }

        if (Mathf.Approximately(life, 0.2f))
        {

        }
    }
}
