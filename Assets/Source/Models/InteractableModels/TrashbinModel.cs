using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashbinModel : InteractableBaseModel
{
    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.TrashBin);
    }

    public override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnClickEnd()
    {
        base.OnClickEnd();
        Debug.Log("THRASHBIN EVENT");
    }
}