using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class Snowbank : MonoBehaviour
{
    [SerializeField] private float _increasingTime;
    [SerializeField] private ParticleSystem _particals;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            player.IncreaseTime(_increasingTime);
            _particals.Play();
            gameObject.SetActive(false);
        }
                  
    }
}
