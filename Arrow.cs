using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float arrowSpeed;
    bool launch;
    public Vector3 arrowDir;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            launch = true;
            transform.parent = null;
            arrowDir = Vector3.forward;
        }
    }

    private void FixedUpdate()
    {
        if (launch == true)
        {
            Vector3 arrowVel = arrowDir * arrowSpeed;
            transform.Translate(arrowVel * Time.deltaTime);
        }
    }
}
