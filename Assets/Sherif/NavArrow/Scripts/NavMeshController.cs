using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    [SerializeField] private Transform m_target;

    private NavMeshAgent _agent;
    private NavMeshPath _path;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Bake new Path"))
        {
            _path = new NavMeshPath();

            _agent.CalculatePath(m_target.position, _path);
        }
    }

    private void OnDrawGizmos()
    {
        if (_path != null && _path.status == NavMeshPathStatus.PathComplete)
        {
            for (int i = 0; i < _path.corners.Length - 1; i++)
            {
                Debug.DrawLine(_path.corners[i], _path.corners[i + 1], Color.red);
                Gizmos.color = Color.green;
                Gizmos.DrawSphere(_path.corners[i], 0.5f);
            }
        }
    }
}
