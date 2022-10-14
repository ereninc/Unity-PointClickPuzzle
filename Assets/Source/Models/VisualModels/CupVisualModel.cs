using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CupVisualModel : VisualBaseModel
{
    [SerializeField] private SkinnedMeshRenderer liquidMesh;
    private float liquidHeightVal = 0;

    public void OnCupClick(bool isFilling)
    {
        Animator.Play("OnWaterChange", 0, 0);
        ParticleSystem.Play();
        if (isFilling)
        {
            DOTween.To(() => liquidHeightVal, x => liquidHeightVal = x, 100, 0.5f)
            .OnUpdate(() =>
            {
                liquidMesh.SetBlendShapeWeight(1, liquidHeightVal);
            });
        }
        else
        {
            DOTween.To(() => liquidHeightVal, x => liquidHeightVal = x, 0, 0.5f)
            .OnUpdate(() =>
            {
                liquidMesh.SetBlendShapeWeight(1, liquidHeightVal);
            });
        }
    }

    public void OnEnterTrashBin()
    {
        Animator.enabled = false;
        transform.DOScale(1.2f, 0.25f).OnComplete(() =>
        {
            transform.DOScale(0f, 0.25f).OnComplete(() => transform.SetActiveGameObject(false));
        });
    }
}