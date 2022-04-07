using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo3
{
    public class TimeBehaviour : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(WaitForTenSeconds());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StopCoroutine(WaitForTenSeconds());
            }
        }

        IEnumerator WaitForTenSeconds()
        {
            yield return new WaitForSeconds(10.0f);
            Destroy(this.gameObject);
        }
    }
}
