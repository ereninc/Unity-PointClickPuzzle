using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CupVisualModel : ObjectModel
{
    [SerializeField] private SkinnedMeshRenderer liquidMesh;
    private float liquidHeightVal = 0;

    public void OnCupClick(bool isFilling)
    {
        if (isFilling)
        {
            DOTween.To(() => liquidHeightVal, x => liquidHeightVal = x, 100, 0.5f)
            .OnUpdate(() => {
                liquidMesh.SetBlendShapeWeight(1, liquidHeightVal);
            });
        }
        else
        {
            DOTween.To(() => liquidHeightVal, x => liquidHeightVal = x, 0, 0.5f)
            .OnUpdate(() => {
                liquidMesh.SetBlendShapeWeight(1, liquidHeightVal);
            });
        }
    }
}
