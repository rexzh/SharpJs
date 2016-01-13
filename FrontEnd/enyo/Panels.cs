using System;

namespace enyo
{
    /// <summary>
    /// The enyo.Panels kind is designed to satisfy a variety of common application layout use cases. For example, controls can be arranged as a carousel, a set of collapsing panels, a card stack that fades between panels, a grid, and more.
    /// Of the set of controls contained inside an enyo.Panels, one is considered active. Any enyo kind can be placed inside an enyo.Panels but by convention we refer to each of these controls as a "panel." The active panel is set by index using the setIndex method.
    /// The layout of panels is controlled by the specified layoutKind. By default, panels fit to the size of the Panels that contains them and transition via fading. To setup a carousel, specify a layoutKind of "CarouselArranger" and give each panel a width.
    /// Panels are also animate and are draggable by default. These behaviors can be defeated by setting the draggable and animate properties to false.
    /// </summary>
    public class Panels : Control
    {
        /// <summary>
        /// Event that fires at the start of a panel transition. Note, this event fires when setIndex is called and also during dragging.
        /// </summary>
        public EnyoEventHandler<Control, EnyoEventArgs> OnTransitionStart;

        /// <summary>
        /// Event that fires at the end of a panel transition. Note, this event fires when setIndex is called and also during dragging.
        /// </summary>
        public EnyoEventHandler<Control, EnyoEventArgs> OnTransitionFinish;

        /// <summary>
        /// Return a reference to the active panel; the panel at the specified index.
        /// </summary>
        /// <returns></returns>
        public Panels GetActive() { return null; }

        /// <summary>
        /// Return a reference to the enyo.Animator instance used to animate panel transitions. The Panels' animator can be used to, for example set the duration of panel transitions: e.g. this.getAnimator().setDuration(1000);
        /// </summary>
        /// <returns></returns>
        public Animator GetAnimator() { return null; }

        /// <summary>
        /// Return an array of contained panels.
        /// </summary>
        /// <returns></returns>
        public Panels[] GetPanels() { return null; }

        /// <summary>
        /// Transition to the next panel; the panel at the index one after the current active panel.
        /// </summary>
        public void Next() { }

        /// <summary>
        /// Transition to the previous panel; the panel at the index one before the current active panel.
        /// </summary>
        public void Previous() { }

        /// <summary>
        /// Specify the index of the active panel. The layout of panels is controlled by the layoutKind, but as a rule, the active panel is displayed in the most prominent position. In the default, CardArranger layout, for example, the active panel is shown and the other panels are hidden.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Controls if the user can drag between panels.
        /// </summary>
        public bool Draggable { get; set; }

        /// <summary>
        /// Controls if the panels animate when transitioning; for example, when setIndex is called.
        /// </summary>
        public bool Animate { get; set; }

        public bool Wrap { get; set; }

        /// <summary>
        /// Sets the arranger kind to be used for dynamic layout.
        /// </summary>
        public ArrangerKind ArrangerKind { get; set; }

        /// <summary>
        /// By default each panel will be sized to fit the Panels' width when the screen size is narrow enough (~800px). Set narrowFit to false to avoid this behavior.
        /// </summary>
        public bool NarrowFit { get; set; }

        /// <summary>
        /// Set the active panel to the panel specified by the given index. Note that if the animate property is set to true, the active panel will animate into view.
        /// </summary>
        /// <param name="idx"></param>
        public void SetIndex(int idx) { }

        /// <summary>
        /// Set the active panel to the panel specified by the given index. Regardless of the setting of the animate property, the transition to the next panel will not animate and will be immediate.
        /// </summary>
        /// <param name="idx"></param>
        public void SetIndexDirect(int idx) { }

        public static bool IsScreenNarrow()
        {
            return false;
        }

        public void Reflow() { }
    }
}
