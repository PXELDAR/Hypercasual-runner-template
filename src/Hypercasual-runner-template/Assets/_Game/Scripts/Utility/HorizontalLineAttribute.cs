﻿using System;
using UnityEngine;

namespace PXELDAR
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class HorizontalLineAttribute : PropertyAttribute
    {
        //=============================================================================

        public const float DefaultHeight = 3.0f;
        public const EColor DefaultColor = EColor.Gray;

        public float Height { get; private set; }
        public EColor Color { get; private set; }

        //=============================================================================

        public HorizontalLineAttribute(float height = DefaultHeight, EColor color = DefaultColor)
        {
            Height = height;
            Color = color;
        }

        //=============================================================================

    }
}
