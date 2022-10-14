using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishController : ControllerBaseModel
{
    public static FinishController Controller;
    [SerializeField] private DoorModel doorModel;

    public override void Initialize()
    {
        base.Initialize();
        if (Controller != null)
        {
            Destroy(Controller);
        }
        else
        {
            Controller = this;
        }
    }

    [EditorButton]
    public void OnLevelFinished() 
    {
        doorModel.OnOpen();
    }
}