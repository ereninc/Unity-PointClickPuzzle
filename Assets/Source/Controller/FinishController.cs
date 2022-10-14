using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishController : ControllerBaseModel
{
    [SerializeField] private DoorModel doorModel;
    [SerializeField] private CharacterModel characterModel;

    public void OnStagesFinished() 
    {

    }

    public void OnLevelFinished() 
    {
        doorModel.OnOpen();
        GameController.ChangeState(GameStates.Win);
        CameraController.Controller.ChangeCamera(1);
        characterModel.OnLevelComplete();
    }
}