using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonView : MonoBehaviour
{
    [SerializeField] private Transform playButtonTransform;
    private float scaleFactor = 1.2f;
    private float animationDuration = 1f;
    [SerializeField] private Button playButton;

    private void OnEnable()
    {
        PlayButtonAnimation();
        playButton.onClick.RemoveAllListeners();
        playButton.onClick.AddListener(() => {
            SceneManager.LoadScene("GameScene");
            }
        );
    }

    private void PlayButtonAnimation()
    {
        playButtonTransform.DOScale(scaleFactor, animationDuration)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
