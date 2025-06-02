using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private RotateMode _rotateMode;

    private void Start()
    {
        transform.DORotate(_position, _duration, _rotateMode)
            .SetLoops(_repeats, _loopType)
            .SetEase(Ease.Linear);
    }
}
