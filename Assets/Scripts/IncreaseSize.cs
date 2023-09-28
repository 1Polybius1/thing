using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    private float _size = 1f;
    private bool _scale = false;
    private SceneController _sceneController;

    private void Start()
    {
        _sceneController = GetComponent<SceneController>();
    }

    private void FixedUpdate()
    {
        if (_scale)
        {

            _size *= 1.1f;

            transform.localScale = new Vector3(_size, _size, 1);
        }

        if (_size >= 9)
        {
            _scale = false;
            _sceneController.GoToScene("LevelOne");
        }
    }

    public void startScale()
        {

            _scale = true;
        }
}
