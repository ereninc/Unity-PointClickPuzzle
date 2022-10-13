using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class PointerController
{
    public Vector2 PointerDownPosition;
    public Vector2 PointerPosition;
    public Vector2 PointerUpPosition;
    public Vector2 DeltaPosition
    {
        get
        {
            return new Vector2((PointerPosition.x - PointerDownPosition.x) / Screen.width, (PointerPosition.y - PointerDownPosition.y) / Screen.height);
        }
    }

    public UnityEvent OnPointerDownEvent;
    public UnityEvent OnPointerEvent;
    public UnityEvent OnPointerUpEvent;

    public void ControllerUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnPointerDown();
        }

        if (Input.GetMouseButton(0))
        {
            OnPointer();
        }

        if (Input.GetMouseButtonUp(0))
        {
            OnPointerUp();
        }
    }

    public void OnPointerDown()
    {
        PointerDownPosition = Input.mousePosition;
        if (OnPointerDownEvent != null)
            OnPointerDownEvent.Invoke();
    }

    public void OnPointer()
    {
        PointerPosition = Input.mousePosition;
        if (OnPointerEvent != null)
            OnPointerEvent.Invoke();
    }

    public void OnPointerUp()
    {
        PointerUpPosition = Input.mousePosition;
        if (OnPointerUpEvent != null)
            OnPointerUpEvent.Invoke();
    }
   
}