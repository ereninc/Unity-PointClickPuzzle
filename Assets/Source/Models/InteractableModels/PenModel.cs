using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenModel : InteractableBaseModel
{
    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Pen);
    }

    public override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnClickEnd()
    {

        base.OnClickEnd();
    }
}