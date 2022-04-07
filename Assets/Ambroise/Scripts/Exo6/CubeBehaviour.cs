using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exo6
{
    public class CubeBehaviour : MonoBehaviour
    {
        protected virtual void Action()
        {
            Debug.Log(this.gameObject.name);
        }

        protected virtual void ResetAction()
        {
            Debug.Log(this.gameObject.name + " got reset");
        }
    }
}