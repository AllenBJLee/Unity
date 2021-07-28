using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterControl : MonoBehaviour
{
    public Transform myTransform;
    public float playerSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("[Start] Called");
        // myTransform.position = new Vector3(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("[Update] Called");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0.0f, vertical);

        //direction = direction.normalized;

        myTransform.position += direction.normalized * Time.deltaTime * playerSpeed;
    }
}
