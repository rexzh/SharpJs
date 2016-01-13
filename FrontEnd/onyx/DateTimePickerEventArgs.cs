using JavaScript;

namespace onyx
{
    [NoCompile]
    public sealed class DateTimePickerEventArgs : enyo.EnyoEventArgs
    {
        public string Name;
        public DateTime Value;
    }
}
