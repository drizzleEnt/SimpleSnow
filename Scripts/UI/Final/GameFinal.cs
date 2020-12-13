using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinal : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private GameObject _winningPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerAnimationSwitcher playerAnimationSwitcher))
        {
            playerAnimationSwitcher.WinningPosition();
            playerAnimationSwitcher.enabled = false;
            _playerMover.enabled = false;
            _player.transform.position = _spawnPoint.transform.position;
            _winningPanel.SetActive(true);
        }
    }
} 
