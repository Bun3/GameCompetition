using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("BUTTON DOWN");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log("RAYCAST " + hit.collider.name);
                if (hit.collider.CompareTag("Object")) hit.transform.GetComponent<Rigidbody>().AddForce(Vector3.back * 100, ForceMode.Acceleration);
            }
        }
    }
}
