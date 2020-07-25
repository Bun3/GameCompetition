using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Managers.Game.Check(collision.transform.name);
        Destroy(collision.transform.gameObject);
    }
}
