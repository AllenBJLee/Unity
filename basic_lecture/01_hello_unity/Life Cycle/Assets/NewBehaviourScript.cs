using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Awake( )
    {
        Debug.Log( "Load Object Data" );
    }

    void OnEnable( )
    {
        Debug.Log( "Object Enabled" );
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log( "Hello, World" );
    }

    void FixedUpdate( )
    {
        Debug.Log( "Move" );
    }

    void Update( )
    {
        Debug.Log( "Update" );
    }


    void LateUpdate( )
    {
        Debug.Log( "Lazy Update" );
    }

    void OnDisable( )
    {
        Debug.Log( "Object Disabled" );
    }

    void OnDestroy( )
    {
        Debug.Log( "Unload Object Data");
    }
}
