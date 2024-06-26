﻿using UnityEngine;
using System.Collections;

namespace AISandbox
{
    [RequireComponent(typeof(IActor))]
    public class EvadeController : MonoBehaviour
    {
        private IActor _actor;
        [SerializeField] PredictionController predictionController;
        private float x_axis, y_axis;
        private void Awake()
        {
            _actor = GetComponent<IActor>();
        }

        private void FixedUpdate()
        {
             x_axis = transform.position.x - predictionController.transform.position.x;
             y_axis = transform.position.y - predictionController.transform.position.y; 
            _actor.SetInput(x_axis, y_axis);
        }
    }
}