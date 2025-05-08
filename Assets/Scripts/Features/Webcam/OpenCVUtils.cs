using OpenCVForUnity.CoreModule;
using UnityEngine;

public static class OpenCVUtils
{
    public static void UpdateQuadFromCorners(Point[] camCorners, GameObject trackedQuad)
    {
        if (camCorners == null || camCorners.Length != 4 || trackedQuad == null)
            return;

        Vector3 tl = new Vector3((float)camCorners[0].x, (float)camCorners[0].y, 0);
        Vector3 tr = new Vector3((float)camCorners[1].x, (float)camCorners[1].y, 0);
        Vector3 br = new Vector3((float)camCorners[2].x, (float)camCorners[2].y, 0);
        Vector3 bl = new Vector3((float)camCorners[3].x, (float)camCorners[3].y, 0);

        trackedQuad.transform.position = (tl + br) / 2f / 100f;
        trackedQuad.transform.localScale = new Vector3(
            Vector3.Distance(tl, tr),
            Vector3.Distance(tl, bl),
            1
        ) / 100f;
    }
}