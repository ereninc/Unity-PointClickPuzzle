using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeHandler : HandlerBaseModel
{
    [SerializeField] ObjectModel[] initalizeElement;
    [SerializeField] bool initializeOnAwake;

    private void Awake()
    {
        if (initializeOnAwake)
            Initialize();
    }

    public override void Initialize()
    {
        foreach (var item in initalizeElement)
        {
            item.Initialize();
        }
    }
}