using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo6
{
    public class CubeRedBehaviour : CubeBehaviour
    {
        protected override void Action()
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x * 0.5f, this.transform.localScale.y * 0.5f, this.transform.localScale.z * 0.5f);
            base.Action();
        }
        protected override void ResetAction()
        {
            this.transform.localScale = new Vector3(1, 1, 1);
            base.ResetAction();
        }
    }
}
