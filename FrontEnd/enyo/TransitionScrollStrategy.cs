using System;

namespace enyo
{
    /// <summary>
    /// enyo.TransitionScrollStrategy is a helper kind that extends enyo.TouchScrollStrategy, optimizing it for scrolling environments in which effecting scroll changes with transforms using CSS transitions is fastest.
    /// </summary>
    public class TransitionScrollStrategy : TouchScrollStrategy
    {
        protected TransitionScrollStrategy() { }
    }
}
