using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkerModel : InteractableBaseModel
{
    [SerializeField] private DrinkerVisualModel drin;

    public override void Initialize()
    {
        base.Initialize();
        OnSpawn(InteractableTypes.Drinker);
    }

    public override void OnInteract()
    {
        base.OnInteract();
        drin.OnTakeWater();
    }
}