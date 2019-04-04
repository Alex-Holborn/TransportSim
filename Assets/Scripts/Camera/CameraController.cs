using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    void Start()
    {
        SetHeight(10f);
    }

    public void SetHeight(float height)
    {
        var pos = transform.position;
        pos = new Vector3(pos.x, height, pos.z);
    }

}
