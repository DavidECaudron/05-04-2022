using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceComparer : MonoBehaviour
{
    #region Exposed

    [SerializeField] private Transform[] m_enemies;

    #endregion

    #region Private
    #endregion

    #region Main
    #endregion

    #region Utils
    #endregion

    #region Debug & Tools

    private void OnGUI()
    {
        var resultName = "";
        var resultSquareDistance = float.MaxValue;
        Transform resultTransform = null;

        if (GUILayout.Button("FindNearest"))
        {
            foreach (var item in m_enemies)
            {
                var enemyToPlayer = transform.position - item.position;

                var sqrMagnitude = Vector3.SqrMagnitude(enemyToPlayer);

                if (sqrMagnitude < resultSquareDistance)
                {
                    resultName = item.name;
                    resultSquareDistance = sqrMagnitude;
                    resultTransform = item;
                }
            }

            Debug.Log($"Nearest Enemy {resultName} at {resultSquareDistance}");
        }
    }

    #endregion
}
