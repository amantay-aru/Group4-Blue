using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public float DefaultLength = 5.0f;
    public GameObject Dot;
    //public VRInputModule InputModule;

    private LineRenderer LineRenderer = null;

    private void Awake()
    {
        LineRenderer = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        UpdateLine();
    }

    private void UpdateLine()
    {
        //use default/distance
        float targetlength = DefaultLength;

        //raycast
        RaycastHit hit = CreateRaycast(targetlength);

        //default
        Vector3 endPosition = transform.position + (transform.forward * targetlength);

        //or based on hit
        if (hit.collider != null)
        {
            endPosition = hit.point;
        }

        //set position of the dot
        Dot.transform.position = endPosition;

        //set linerenderer
        LineRenderer.SetPosition(0, transform.position);
        LineRenderer.SetPosition(1, endPosition);
    }

    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, DefaultLength);

        return hit;
    }
}
