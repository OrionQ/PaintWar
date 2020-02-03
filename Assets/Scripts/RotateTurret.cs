using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTurret : MonoBehaviour
{
    public enum ROTATION_AXIS
    {
        xAxis,
        yAxis,
        zAxis
    }
    public float maxRotationAngle;
    public float period;

    float myTime;
    public ROTATION_AXIS rotationAxis;


    // Update is called once per frame
    void Update()
    {
        if (rotationAxis == ROTATION_AXIS.xAxis)
        {
            myTime += Time.deltaTime;
            float phase = Mathf.Sin(myTime / period);
            transform.localRotation = Quaternion.Euler(new Vector3(phase * maxRotationAngle, 0, 0));
        } else if (rotationAxis == ROTATION_AXIS.yAxis)
        {
            myTime += Time.deltaTime;
            float phase = Mathf.Sin(myTime / period);
            transform.localRotation = Quaternion.Euler(new Vector3(0, phase * maxRotationAngle, 0));
        } else if (rotationAxis == ROTATION_AXIS.zAxis)
        {
            myTime += Time.deltaTime;
            float phase = Mathf.Sin(myTime / period);
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, phase * maxRotationAngle));
        }
    }
}
