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
    }

    #endregion
}
