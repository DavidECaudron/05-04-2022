using System;
using UnityEngine;

/// <summary> My namespace description </summary>
namespace HelloWorld.Runtime
{
    /// <summary> My class description </summary>
    public class HelloWorld : MonoBehaviour
    {
#region Exposed

        public bool m_isVerbose;

        [Space(10)]
        /// <summary> My property description </summary>
        public int m_life;

        [SerializeField]
        private int _maxLife;

#endregion

#region Unity API

        private void Start()
        {
            GatherInput();
#if UNITY_STANDALONE
            MovePlayer();
            RotatePlayer();
#endif
        }

#endregion

#region Main

        private void GatherInput()
        {
            Verbose("ça choppe les inputs");
        }

        private void MovePlayer()
        {
            Verbose("ça bouge");
        }

        private void RotatePlayer()
        {
            Verbose("ça tourne");
            CalculatePlayerAngleFromCamera();
        }

#endregion

#region Utils

        private void CalculatePlayerAngleFromCamera()
        {
            throw new NotImplementedException();
        }

#endregion

#region Debug & Tools

        public void Verbose(string message)
        {
            if (m_isVerbose)
            {
                Debug.Log(message);
            }
        }

#endregion

#region Private

#endregion
    }
}
