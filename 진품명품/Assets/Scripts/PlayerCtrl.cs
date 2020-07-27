using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 1f;

    Transform camTra;
    Transform fixedTra;
    Transform fixedObj;
    bool fixedTrue;
    private void Awake()
    {
        camTra = transform.Find("Camera");
        fixedTra = camTra.Find("Fixed");
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    float horizontal;
    float vertical;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;

            Managers.UI.titleStartButton();
        }

        if (Cursor.lockState == CursorLockMode.Locked)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            float h = Input.GetAxis("Mouse X");
            float v = Input.GetAxis("Mouse Y") * -1;

            camTra.Rotate(v, 0, 0, Space.Self);

            transform.Rotate(0, h, 0, Space.World);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;

            if (fixedObj == null)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    if (null == hit.rigidbody) return;
                    if (hit.rigidbody.transform.CompareTag("Object"))
                    {
                        fixedObj = hit.rigidbody.transform;
                    }
                }
            }

        }

        if (Input.GetMouseButton(0))
        {
            if (fixedObj == null) return;

            fixedObj.transform.position = fixedTra.position;
            fixedObj.transform.rotation = fixedTra.rotation;
        }

        if (Input.GetMouseButtonUp(0))
        {
            fixedObj = null;
            //fixedJoi.connectedBody = null;
        }

    }

    private void LateUpdate()
    {
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed);
    }
}
