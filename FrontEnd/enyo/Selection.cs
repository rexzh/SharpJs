using System;

namespace enyo
{
    public class Selection : Component
    {
        /// <summary>
        /// remove all selections
        /// </summary>
        public void Clear() { }

        /// <summary>
        /// deselect a row
        /// </summary>
        /// <param name="key"></param>
        public void Deselect(object key) { }

        /// <summary>
        /// return the selection, it's a hash
        /// </summary>
        /// <returns></returns>
        public object GetSelected()
        {
            return null;
        }

        /// <summary>
        /// returns true if the inKey row is selected
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool IsSelected(object key) { return false; }

        /// <summary>
        /// if true, allow multiple selections
        /// </summary>
        public bool Multi { get; set; }

        /// <summary>
        /// select a row. If the selection has the multi property set to false, it will also deselect the previous selection.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public void Select(object key, object data)
        {
        }

        /// <summary>
        /// manually set a row to selected or unselected
        /// </summary>
        /// <param name="key"></param>
        /// <param name="selected"></param>
        /// <param name="data"></param>
        public void SetByKey(object key, bool selected, object data) { }

        /// <summary>
        /// Toggle selection for a row. If the multi is false, toggling a selection on will deselect the previous selection.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public void Toggle(object key, object data) { }

        /*Extend:Not expose
        onSelect: function(inSender, inKey, inPrivateData) {    
            inKey is whatever key was used to register the selection, usually a row index.
            inPrivateData references data registered with this key by the code that made the selection.
        onDeselect: 
        onChange: ""
            Sent when selection changes (but not when the selection is cleared).
        */
    }
}
