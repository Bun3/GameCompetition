using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCheck : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.transform.CompareTag("Object"))
        {
            Managers.Game.Check(false);
            Destroy(collision.transform.gameObject);
        }
    }
}
