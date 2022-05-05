using UnityEngine;
using UnityEngine.UI;

public class WallCreator : MonoBehaviour
{
    [SerializeField] GameObject _brick;
    [SerializeField] GameObject _wallPoint;
    [SerializeField] GameObject _curzorPoint;
    [SerializeField] Vector3 _curzorPointPosition;
    
    [SerializeField] bool _curzorEnable;

    [SerializeField] int _wallXSpace;
    [SerializeField] int _wallYSpace;
    [SerializeField] int _wallZSpace ;

    [SerializeField] Button _wButton;
    [SerializeField] Button _sButton;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _curzorPoint.transform.position = _curzorPointPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _curzorEnable = !_curzorEnable;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (_curzorEnable)
            {
                Instantiate(_brick, _curzorPointPosition, _curzorPoint.transform.rotation, _wallPoint.transform);
            }
            _curzorPointPosition.z += _wallZSpace;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (_curzorEnable)
            {
                Instantiate(_brick, _curzorPointPosition, _curzorPoint.transform.rotation, _wallPoint.transform);
            }
            _curzorPointPosition.z -= _wallZSpace;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (_curzorEnable)
            {
                Instantiate(_brick, _curzorPointPosition, _curzorPoint.transform.rotation, _wallPoint.transform);
            }
            _curzorPointPosition.x += _wallXSpace;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (_curzorEnable)
            {
                Instantiate(_brick, _curzorPointPosition, _curzorPoint.transform.rotation, _wallPoint.transform);
            }
            _curzorPointPosition.x -= _wallXSpace;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_curzorEnable)
            {
                Instantiate(_brick, _curzorPointPosition, _curzorPoint.transform.rotation, _wallPoint.transform);
            }
            _curzorPointPosition.y += _wallYSpace;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (_curzorEnable)
            {
                Instantiate(_brick, _curzorPointPosition, _curzorPoint.transform.rotation, _wallPoint.transform);
            }
            _curzorPointPosition.y -= _wallYSpace;
        }
    }
}
