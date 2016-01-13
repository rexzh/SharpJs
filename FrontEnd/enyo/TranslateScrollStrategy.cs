using System;

namespace enyo
{
    /// <summary>
    /// enyo.TranslateScrollStrategy is a helper kind that extends enyo.TouchScrollStrategy, optimizing it for scrolling environments in which effecting scroll changes with transform is fastest.
    /// enyo.TranslateScrollStrategy is not typically created in application code.
    /// </summary>
    public class TranslateScrollStrategy : TouchScrollStrategy
    {
        protected TranslateScrollStrategy() { }
    }
}
