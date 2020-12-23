using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class vrMap
{
    public Transform vrTarget;
    public Transform rigTarget;
    public Vector3 trackingPositionOffset;
    public Vector3 trackingRotationOffset;

    public void Map()
    {
        //rigTarget.position = vrTarget.TransformPoint(trackingPositionOffset);
        rigTarget.rotation = vrTarget.rotation * Quaternion.Euler(trackingRotationOffset);
    }

}

public class vrMovement : MonoBehaviour
{
    public vrMap head;
    public vrMap leftHand;
    public vrMap rightHand;

    public Transform headConstraint;
    public Vector3 headBodyOffset;

    void Start()
    {
        headBodyOffset = transform.position - headConstraint.position;
    }

    void LateUpdate()
    {
        //transform.position = headConstraint.position + headBodyOffset;
        transform.forward = Vector3.ProjectOnPlane(headConstraint.up,Vector3.up).normalized;

        head.Map();
        leftHand.Map();
        rightHand.Map();
    }
}
