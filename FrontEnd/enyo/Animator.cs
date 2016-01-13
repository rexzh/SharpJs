using System;

namespace enyo
{
    public class Animator : Component
    {
        /// <summary>
        /// Fires when an animation step occurs.
        /// </summary>
        public EnyoEventHandler<Animator, EnyoEventArgs> OnStep;

        /// <summary>
        /// Fires when the animation finishes normally.
        /// </summary>
        public EnyoEventHandler<Animator, EnyoEventArgs> OnEnd;

        /// <summary>
        /// Fires when the animation is prematurely stopped.
        /// </summary>
        public EnyoEventHandler<Animator, EnyoEventArgs> OnStop;

        /// <summary>
        /// Returns true if animation is in progress.
        /// </summary>
        /// <returns></returns>
        public bool IsAnimating()
        {
            return false;
        }

        /// <summary>
        /// Plays the animation.
        /// </summary>
        /// <param name="props">props will be mixed directly into this object.</param>
        public void Play(object props = null)
        {
        }

        /// <summary>
        /// Stops the animation and fires the onStop event.
        /// </summary>
        public void Stop()
        {
        }

        /// <summary>
        /// Animation duration in milliseconds
        /// </summary>
        public int Duration { get; set; }

        public int StartValue { get; set; }
        public int EndValue { get; set; }

        /// <summary>
        /// Node that must be visible in order for the animation to continue. This reference is destroyed when the animation ceases.
        /// </summary>
        public object Node { get; set; }

        public Func<int, int> EasingFunction { get; set; }
    }
}
