using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo6
{
    public class CubeGreenBehaviour : CubeBehaviour
    {
        protected override void Action()
        {
            this.transform.Rotate(new Vector3(0, 45, 0));
            base.Action();
        }
        protected override void ResetAction()
        {
            this.transform.rotation = Quaternion.identity;
            base.ResetAction();
        }
    }
}
