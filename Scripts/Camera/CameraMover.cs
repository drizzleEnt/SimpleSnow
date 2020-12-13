using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private float _speed;

    
    private void Update()
    {
        Vector3 position = _target.transform.position;
        position.z = -10;
        transform.position = Vector3.Lerp(transform.position, position, _speed * Time.deltaTime);
    }

   
}
