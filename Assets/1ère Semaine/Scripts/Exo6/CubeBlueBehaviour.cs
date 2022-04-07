using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo6
{
    public class CubeBlueBehaviour : CubeBehaviour
    {
        [SerializeField] private Material materialBlack;
        [SerializeField] private Material materialBlue;

        private MeshRenderer meshRenderer;

        private void Start()
        {
            meshRenderer = this.GetComponent<MeshRenderer>();
        }

        protected override void Action()
        {
            meshRenderer.material = materialBlack;
            base.Action();
        }
        protected override void ResetAction()
        {
            meshRenderer.material = materialBlue;
            base.ResetAction();
        }
    }
}
