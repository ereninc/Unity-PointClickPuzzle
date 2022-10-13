using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupModel : InteractableBaseModel
{
    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Cup);
    }

    public override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnClickEnd()
    {
        Debug.Log("Water filled");
        base.OnClickEnd();
    }
}