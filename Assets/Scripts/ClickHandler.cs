using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    private Shape _shape;

    private void Start()
    {
        if (gameObject.GetComponent<CubeShape>())
        {
            _shape = GetComponent<CubeShape>();
        }
        else if (gameObject.GetComponent<SphereShape>())
        {
            _shape = GetComponent<SphereShape>();
        }
        else if (gameObject.GetComponent<CapsuleShape>())
        {
            _shape = GetComponent<CapsuleShape>();
        }
    }

    private void OnMouseDown()
    {
        _shape.DisplayText();
    }
}
