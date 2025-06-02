using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private float _delay;

    private void Start()
    {
        _delay = _duration;

        _text.DOText("Последовательно заменяю текст текст", _duration);
        _text.DOText("Дополняю текст", _duration).SetRelative().SetDelay(_delay);

        _delay += _delay;

        _text.DOText("Идет взлом текста текста текста", _duration, true, ScrambleMode.All).SetDelay(_delay);
    }
}
