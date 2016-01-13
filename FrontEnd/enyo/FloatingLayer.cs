using System;

namespace enyo
{
    /// <summary>
    /// enyo.FloatingLayer is a control that provides a layer for controls that should be displayed above an application. The FloatingLayer singleton can be set as a control parent to have the control float above an application.
    /// Note: It's not intended that users create instances of enyo.FloatingLayer.
    /// </summary>
    public sealed class FloatingLayer : Control
    {
        private FloatingLayer() { }
    }
}
