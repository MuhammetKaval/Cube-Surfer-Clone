using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInputSystem : MonoBehaviour
{
    private float _lastFrameFingerPositionX;
    private float _moveFactoryX;

    public float MoveFactoryX => _moveFactoryX;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastFrameFingerPositionX = Input.mousePosition.x;
        }

        else if (Input.GetMouseButton(0))
        {
            _moveFactoryX = Input.mousePosition.x - _lastFrameFingerPositionX;
            _lastFrameFingerPositionX = Input.mousePosition.x;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            _moveFactoryX = 0f;
        }
    }
}
