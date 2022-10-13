using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkerModel : InteractableBaseModel
{
    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Drinker);
    }

    public override void OnInteract()
    {
        base.OnInteract();
    }

    public override void OnClickEnd()
    {
        base.OnClickEnd();
        Debug.Log("DRINKER aaaaa");
    }
}