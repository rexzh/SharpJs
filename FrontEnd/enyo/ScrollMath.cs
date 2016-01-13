using System;

namespace enyo
{
    /// <summary>
    /// enyo.ScrollMath implements a scrolling dynamics simulation. It is a helper kind used by other scroller kinds, such as enyo.TouchScrollStrategy.
    /// enyo.ScrollMath is not typically created in application code.
    /// </summary>
    public class ScrollMath : Component
    {
        private ScrollMath() { }

        /// <summary>
        /// Flag to enable frame-based animation, otherwise use time-based animation.
        /// </summary>
        public bool FixedTime;

        /// <summary>
        /// Animation time step
        /// </summary>
        public int Interval;

        /// <summary>
        /// 'drag' damping resists dragging the scroll position beyond the boundaries. Lower values provide MORE resistance.
        /// </summary>
        public float KDragDamping;

        /// <summary>
        /// Scalar applied to 'flick' event velocity
        /// </summary>
        public int KFlickScalar;

        /// <summary>
        /// 'friction' damping reduces momentum over time. Lower values provide MORE friction).
        /// </summary>
        public float KFrictionDamping;

        /// <summary>
        /// The value used in friction() to determine if the delta (e.g., y - y0) is close enough to zero to consider as zero.
        /// </summary>
        public float KFrictionEpsilon;

        /// <summary>
        /// Limits the maximum allowable flick. On Android > 2, we limit this to prevent compositing artifacts.
        /// </summary>
        public int KMaxFlick;

        /// <summary>
        /// Additional 'friction' damping applied when momentum carries the viewport into overscroll. Lower values provide MORE friction.
        /// </summary>
        public float KSnapFriction;

        /// <summary>
        /// 'spring' damping returns the scroll position to a value inside the boundaries. Lower values provide FASTER snapback.
        /// </summary>
        public float KSpringDamping;

        /// <summary>
        /// Left snap boundary, generally 0.
        /// </summary>
        public int LeftBoundary;

        /// <summary>
        /// Right snap boundary, generally = viewport width - content width.
        /// </summary>
        public int RightBoundary;

        /// <summary>
        /// Top snap boundary, generally 0.
        /// </summary>
        public int TopBoundary;

        /// <summary>
        /// Bottom snap boundary, generally = viewport height - content height.
        /// </summary>
        public int BottomBoundary;

        public bool Vertical { get; set; }
        public bool Horizontal { get; set; }
    }
}
