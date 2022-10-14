using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScreen : ScreenElement
{
    [SerializeField] private Transform highlightButton;

    public void OnShow() 
    {
        highlightButton.SetActiveGameObject(true);
    }
}