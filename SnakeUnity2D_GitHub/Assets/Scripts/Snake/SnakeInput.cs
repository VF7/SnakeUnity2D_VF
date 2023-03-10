using System;
using UnityEngine;

public class SnakeInput : MonoBehaviour
{
    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    public Vector2 GetDirectionToClick(Vector2 headPosition)
    {
        var clickPosition = Input.mousePosition;
        
        clickPosition = _mainCamera.ScreenToViewportPoint(clickPosition);
        clickPosition.y = 1f;
        clickPosition = _mainCamera.ViewportToWorldPoint(clickPosition);
        
        var direction = new Vector2(clickPosition.x - headPosition.x, clickPosition.y - headPosition.y);
        
        return direction;
    }
}
