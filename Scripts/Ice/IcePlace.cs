using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePlace : MonoBehaviour
{
    [SerializeField] private float _speedUp;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover player))
            player.IncreaseSpeed(_speedUp);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover player))
            player.SetSpeedNormal();
    }
}
