using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CupVisualModel : ObjectModel
{
    [SerializeField] private SkinnedMeshRenderer liquidMesh;
    [SerializeField] private ParticleSystem splashParticle;
    [SerializeField] private Animator animator;
    private float liquidHeightVal = 0;

    public void OnCupClick(bool isFilling)
    {
        animator.Play("OnWaterChange", 0, 0);
        if (isFilling)
        {
            DOTween.To(() => liquidHeightVal, x => liquidHeightVal = x, 100, 0.5f)
            .OnUpdate(() =>
            {
                liquidMesh.SetBlendShapeWeight(1, liquidHeightVal);
            });
            splashParticle.Play();
        }
        else
        {
            DOTween.To(() => liquidHeightVal, x => liquidHeightVal = x, 0, 0.5f)
            .OnUpdate(() =>
            {
                liquidMesh.SetBlendShapeWeight(1, liquidHeightVal);
            });
            splashParticle.Play();
        }
    }

    public void OnEnterTrashBin()
    {
        animator.enabled = false;
        transform.DOScale(1.2f, 0.25f).OnComplete(() =>
        {
            transform.DOScale(0f, 0.25f).OnComplete(() => transform.SetActiveGameObject(false));
        });
    }
}