using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo4
{
    public class ColorChange : MonoBehaviour
    {
        [SerializeField] private Material materialGreen;
        [SerializeField] private Material materialRed;

        private MeshRenderer meshRenderer;

        private void Start()
        {
            meshRenderer = this.GetComponent<MeshRenderer>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            meshRenderer.material = materialRed;
        }

        private void OnCollisionExit(Collision collision)
        {
            meshRenderer.material = materialGreen;
        }
    }
}