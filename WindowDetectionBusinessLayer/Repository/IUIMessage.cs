namespace WindowDetectionBusinessLayer
{
    interface IUIMessage
    {
        void DisplayInvalidTextError();
        void DisplayWindowFound();
        void DisplayWindowNotFound();
        void DisplayAppOnExit();
        void DisplayInvalidProcessName();
    }
}
