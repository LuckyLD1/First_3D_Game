using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    Vector3 eulersAngles;
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            eulersAngles = gameObject.transform.rotation.eulerAngles;
            gameObject.transform.rotation = Quaternion.Euler(eulersAngles.x, eulersAngles.y + .1f, eulersAngles.z);
            Debug.Log("Pressed");
        }
    }
}
