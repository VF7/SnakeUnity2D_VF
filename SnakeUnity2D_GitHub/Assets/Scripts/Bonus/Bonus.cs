using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bonus : MonoBehaviour
{
    [SerializeField] private Vector2Int _bonusSizeRange;
    [SerializeField] private TMP_Text _view;

    private int _bonusSize;
    public int BonusSize => _bonusSize;

    private void Start()
    {
        _bonusSize = Random.Range(_bonusSizeRange.x, _bonusSizeRange.y);
        _view.text = _bonusSize.ToString();
    }
}
