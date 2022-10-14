using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : ControllerBaseModel
{
    public static CameraController Controller;
    [SerializeField] private CinemachineVirtualCamera[] virtualCameras;
    public CinemachineVirtualCamera ActiveCamera;

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

    public void ChangeCamera(int index)
    {
        ActiveCamera.SetActiveGameObject(false);
        ActiveCamera = virtualCameras[index];
        ActiveCamera.SetActiveGameObject(true);
    }
}