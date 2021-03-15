using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 1f;
    [SerializeField] float zAngle = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
