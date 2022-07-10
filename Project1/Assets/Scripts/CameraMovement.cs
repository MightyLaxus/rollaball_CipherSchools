using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _Ball;
    [SerializeField] private Vector3 _offset;
    private void Start()
    {
        _offset = transform.position - _Ball.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = _Ball.transform.position + _offset;
    }
}
