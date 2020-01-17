using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiopsyPath : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public SurgicalPointBiopsy biopsyPoint;
    public SurgicalPointEntry entryPoint;

    // Update is called once per frame
    void Update()
    {
        if(biopsyPoint && entryPoint)
        {
            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0, biopsyPoint.transform.position);
            lineRenderer.SetPosition(1, entryPoint.transform.position);
        }
        else
        {
            lineRenderer.positionCount = 0;
        }
    }
}
