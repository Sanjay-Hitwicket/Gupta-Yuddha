using System;
using DG.Tweening;
using UnityEngine;

public class PlayButtonView : MonoBehaviour
{
    [SerializeField] private Transform playButton;
    private float scaleFactor = 1.2f;
    private float animationDuration = 1f;

    private void OnEnable()
    {
        PlayButtonAnimation();
    }

    private void PlayButtonAnimation()
    {
        playButton.DOScale(scaleFactor, animationDuration)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
