using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishController : ControllerBaseModel
{
    [SerializeField] private DoorModel doorModel;
    [SerializeField] private CharacterModel characterModel;

    public void OnLevelFinished()
    {
        CameraController.Controller.ChangeCamera(1);
        GameController.ChangeState(GameStates.Win);
        characterModel.OnLevelComplete();
        doorModel.OnOpen();
    }
}