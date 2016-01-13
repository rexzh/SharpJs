using System;

namespace enyo
{
    /// <summary>
    /// Slideable is a control that can be dragged either left/right or up/down between a minimum and maximum value. When released from dragging, a Slideable will animate to its minimum or maximum position based on the direction dragged.
    /// The min value may be specified to indicate a position left or top of initial position to which the Slideable may be dragged. The max value may be specified to indicate a position right or bottom of initial position to which the Slideable may be dragged. The value property may be specified to position the Slideable between its minimum and maximum positions.
    /// The units may be specified as "px" or "%" and indicate the unit for min, max, and value. The axis property controls if the Slideable slides left-right (h) or up-down (v).
    /// </summary>
    public class Slideable : Control
    {
        /// <summary>
        /// Animate to the given value.
        /// </summary>
        /// <param name="val"></param>
        public void AnimateTo(int val) { }

        /// <summary>
        /// Animate to the maximum value
        /// </summary>
        public void AnimateToMax() { }

        /// <summary>
        /// Animate to the minimum value
        /// </summary>
        public void AnimateToMin() { }

        /// <summary>
        /// Event which fires when the Slideable finishes animating.
        /// </summary>
        public EnyoEventHandler<Control, EnyoEventArgs> OnAnimateFinish;

        public EnyoEventHandler<Control, EnyoEventArgs> OnChange;

        public bool PreventDragPropagation;

        /// <summary>
        /// Specifies direction of sliding h or v
        /// </summary>
        public Direction Axis { get; set; }

        /// <summary>
        /// A value between min and max to position the Slideable
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Unit for min, max, and value; can be "px" or "%"
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// A minimum value to slide to
        /// </summary>
        public int Min { get; set; }

        /// <summary>
        /// A maximum value to slide to
        /// </summary>
        public int Max { get; set; }

        /// <summary>
        /// Default "auto"
        /// </summary>
        public string Accelerated { get; set; }

        /// <summary>
        /// Set to false to prevent the Slideable from dragging with elasticity past its min/max value.
        /// </summary>
        public bool OverMoving { get; set; }

        /// <summary>
        /// Set to false to disable dragging.
        /// </summary>
        public bool Draggable { get; set; }

        /// <summary>
        /// Toggle between min and max with animation.
        /// </summary>
        public void ToggleMinMax() { }
    }
}
