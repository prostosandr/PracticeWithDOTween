using DG.Tweening;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    [SerializeField] private float _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_scale, _duration)
            .SetLoops(_repeats, _loopType)
            .SetEase(Ease.Linear);
    }
}
