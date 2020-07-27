using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObject : MonoBehaviour
{
    public bool isTrue = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.transform.CompareTag("Object"))
        {
            Managers.Game.Check(isTrue == collision.rigidbody.transform.GetComponent<ObjectCtrl>().isTrue);
            Destroy(collision.transform.gameObject);
        }
    }
}
