using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        _position += transform.position;

        transform.DOMove(_position, _duration)
            .SetLoops(_repeats, _loopType)
            .SetEase(Ease.Linear);
    }
}
