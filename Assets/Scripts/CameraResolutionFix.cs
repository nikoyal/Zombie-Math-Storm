using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolutionFix : MonoBehaviour
{
    public float orthographicSize = 5;
    public float aspect = 1.33333f;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Camera.main.projectionMatrix = Matrix4x4.Ortho(
            -orthographicSize * aspect, orthographicSize * aspect,
            -orthographicSize, orthographicSize,
            GetComponent<Camera>().nearClipPlane, GetComponent<Camera>().farClipPlane);
    }
}
