using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _lifeTime;
    [SerializeField] private int _maxLifeTime;

    private float _currentTime;
    
    public event UnityAction<float> IsTimeChanged;
    public event UnityAction IsTimeRunOut;
    public event UnityAction IsComeIntoTrigger;
    
    public int MaxLifeTime { get; private set; }

    private void Awake()
    {
        MaxLifeTime = _maxLifeTime;
    }
    private void Start()
    {        
        _currentTime = _lifeTime;
        IsTimeChanged?.Invoke(_currentTime);
    }

    private void Update()
    {
        DecreaseTime();
    }

    private void DecreaseTime()
    {
        _currentTime -= Time.deltaTime;
        IsTimeChanged?.Invoke(_currentTime);
        if (_currentTime <= 0)
            IsTimeRunOut?.Invoke();
    }

    public void IncreaseTime(float increaseTime)
    {
        _currentTime += increaseTime;
        if (_currentTime > _maxLifeTime)
            _currentTime = _maxLifeTime;
        IsTimeChanged?.Invoke(_currentTime);
        IsComeIntoTrigger?.Invoke();
    }
}
