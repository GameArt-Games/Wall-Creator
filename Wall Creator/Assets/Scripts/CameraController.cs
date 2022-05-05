using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float _speedH;
    [SerializeField] float _speedV;

    [SerializeField] float _yaw;
    [SerializeField] float _pitch;

    [SerializeField] float _camMoveX;
    [SerializeField] float _camMoveZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _yaw += _speedH * Input.GetAxis("Mouse X");
        _pitch -= _speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(_pitch,_yaw,0);

        _camMoveX = _speedH * Input.GetAxis("Horizontal") * Time.deltaTime;
        _camMoveZ = _speedV * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(_camMoveX, 0, _camMoveZ));
    }
}
