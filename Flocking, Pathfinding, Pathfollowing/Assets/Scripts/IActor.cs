﻿using UnityEngine;

namespace AISandbox
{
    public interface IActor
    {
        void SetInput(float x_axis, float y_axis);
     
        float MaxSpeed { get; }
        Vector2 Velocity { get; }
    }
}