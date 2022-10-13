using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : ControllerBaseModel
{
    [SerializeField] private PointerController pointerController;
    [Header("Movement")]
    public float ForwardSpeed;
    public float RotationSpeed;
    public float ExtraForwardSpeed;
    public int State;
    [SerializeField] private Vector3 movePosition;
    [SerializeField] private float sensitive;
    [SerializeField] private float xPosition;
    [SerializeField] private float lastXPosition;
    [SerializeField] private float roadXLimit;
    [SerializeField] Transform character; //CHANGE THIS TO CHARACTERMODEL
    float xPos;

    public override void Initialize()
    {
        base.Initialize();
    }

    public override void ControllerUpdate(GameStates currentState)
    {
        base.ControllerUpdate(currentState);
        if (currentState == GameStates.Game)
        {
            movementUpdate();
            pointerController.ControllerUpdate();
        }
    }

    public void OnPointerDown() 
    { 
        lastXPosition = xPosition;
    }

    public void OnPointer() 
    {
        xPosition = lastXPosition + pointerController.DeltaPosition.x * sensitive;
        xPosition = Mathf.Clamp(xPosition, -roadXLimit, roadXLimit);
    }

    public void OnPointerUp() 
    {
        lastXPosition = xPosition;
    }

    private void movementUpdate()
    {
        xPos = xPosition;
        character.localPosition = Vector3.MoveTowards(character.localPosition, new Vector3(xPos, 0, 0), 0.5f);
        movePosition = new Vector3(0, 0, transform.position.z + ((1 + ExtraForwardSpeed) * ForwardSpeed * Time.deltaTime));
        transform.position = movePosition;
        Debug.Log("UPDATE");
    }
}