using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _healthBar.maxValue = _player.MaxLifeTime;
        _player.IsTimeChanged += ChangeHealthValue;
        _player.IsTimeRunOut += DisableHealthBar;
    }

    private void OnDisable()
    {
        _player.IsTimeChanged -= ChangeHealthValue;
        _player.IsTimeRunOut -= DisableHealthBar;
    }

    private void ChangeHealthValue(float health)
    {
        _healthBar.value = health;
    }

    private void DisableHealthBar()
    {
        _healthBar.gameObject.SetActive(false);
    }

}
