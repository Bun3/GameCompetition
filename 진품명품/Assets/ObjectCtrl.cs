using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCtrl : MonoBehaviour
{
    public bool isTrue;
    CBCtrl cb;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ConveyorBelt")) cb = collision.transform.GetComponent<CBCtrl>();
    }

    private void Update()
    {
        if (null != cb)
            if (cb.isGoing)
                transform.Translate(Vector3.right * Time.deltaTime, Space.World);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("ConveyorBelt"))
            cb = null;
    }
}
