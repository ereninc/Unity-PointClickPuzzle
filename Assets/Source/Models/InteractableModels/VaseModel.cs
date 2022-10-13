using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseModel : InteractableBaseModel
{
    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Vase);
    }

    public override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnClickEnd()
    {
        base.OnClickEnd();
        Debug.Log("VASE WENT WET");
    }
}