using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GUILayout;

public class MathDiscovery : MonoBehaviour
{
    #region Day One Addition of vectors

    private void AddVectorUnity( Vector3 firstVector, Vector3 secondVector )
    {
        Debug.Log( $"Add Vector Unity { firstVector + secondVector }" );
    }

    private void AddVectorMath( Vector3 firstVector, Vector3 secondVector )
    {
        var result = firstVector;

        result.x += secondVector.x;
        result.y += secondVector.y;
        result.z += secondVector.z;

        Debug.Log( $"Add Vector Math { result }" );
    }

    #endregion

    #region Day Two Substraction of vectors

    private void SubVectorUnity( Vector3 firstVector, Vector3 secondVector )
    {
        Debug.Log( $"Sub Vector Unity { firstVector - secondVector }" );
    }
    private void SubVectorMath( Vector3 firstVector, Vector3 secondVector )
    {
        var result = firstVector;

        result.x -= secondVector.x;
        result.y -= secondVector.y;
        result.z -= secondVector.z;

        Debug.Log( $"Sub Vector Math { result }" );
    }

    #endregion

    #region Day three

    private void DistanceMath(Vector3 firstVector, Vector3 secondVector)
    {
        float result = 0.0f;

        result = Mathf.Pow(secondVector.x - firstVector.x, 2.0f);
        result += Mathf.Pow(secondVector.y - firstVector.y, 2.0f);
        result += Mathf.Pow(secondVector.z - firstVector.z, 2.0f);

        result = Mathf.Sqrt(result);

        Debug.Log($"Distance Vector Math: {result}");
    }

    private void DistanceUnity(Vector3 firstVector, Vector3 secondVector)
    {
        Debug.Log($"Distance Vector Unity: {Vector3.Distance(firstVector, secondVector)}");
    }

    #endregion

    #region Day Four Scale vectors

    private void ScaleVectorUnity(Vector3 firstVector, float scale)
    {
        Debug.Log($"Scale Vector Unity before scale: {firstVector.magnitude}");

        var vecScale = Vector3.one * scale;
        firstVector.Scale(vecScale);

        Debug.Log($"Scale Vector Unity after scale: {firstVector.magnitude}");
    }

    private void ScaleVectorMath(Vector3 firstVector, float scale)
    {
        Debug.Log($"Scale Vector Math before scale: {firstVector.magnitude}");

        firstVector.x *= scale;
        firstVector.y *= scale;
        firstVector.z *= scale;

        Debug.Log($"Scale Vector Math after scale: {firstVector.magnitude}");
    }

    #endregion

    #region Debug & Tools

    private void OnGUI()
    {
        Label( "Vector3" );

        Space(2);
        if (Button( "Add Vector (Unity)" ))
        {
            var firstVector = new Vector3( 1, 0, 1 );
            var secondVector = new Vector3( 0, 1, 0 );

            AddVectorUnity( firstVector, secondVector );
        }
            
        if (Button( "Add Vector (Maths)" ))
        {
            var firstVector = new Vector3( 1, 0, 1 );
            var secondVector = new Vector3( 0, 1, 0 );

            AddVectorMath( firstVector, secondVector );
        }

        Space(2);
        if (Button( "Sub Vector (Unity)" ))
        {
            var firstVector = new Vector3( 1, 0, 1 );
            var secondVector = new Vector3( 0, 1, 0 );

            SubVectorUnity( firstVector, secondVector );
        }
        if (Button( "Sub Vector (Maths)" ))
        {
            var firstVector = new Vector3( 1, 0, 1 );
            var secondVector = new Vector3( 0, 1, 0 );

            SubVectorMath( firstVector, secondVector );
        }

        Space(2);
        if (Button("Distance (Unity)"))
        {
            var firstVector = new Vector3(1, 0, 1);
            var secondVector = new Vector3(0, 1, 0);

            DistanceUnity(firstVector, secondVector);
        }
        if (Button("Distance (Maths)"))
        {
            var firstVector = new Vector3(1, 0, 1);
            var secondVector = new Vector3(0, 1, 0);

            DistanceMath(firstVector, secondVector);
        }

        Space(2);
        if (Button("Scale Vector (Unity)"))
        {
            var firstVector = new Vector3(1, 0, 1);
            var scale = 2.0f;

            ScaleVectorUnity(firstVector, scale);
        }
        if (Button("Scale Vector (Maths)"))
        {
            var firstVector = new Vector3(1, 0, 1);
            var scale = 2.0f;

            ScaleVectorMath(firstVector, scale);
        }
    }

    #endregion
}
