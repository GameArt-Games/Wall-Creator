using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curzor : MonoBehaviour
{
    GameObject _tempObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Brick")
        {
            _tempObject = other.gameObject;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            Destroy(_tempObject);
        }
    }
}
