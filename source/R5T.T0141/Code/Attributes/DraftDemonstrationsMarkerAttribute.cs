using System;

using R5T.T0143;


namespace R5T.T0141
{
    /// <summary>
    /// Attribute indicating an interface contains draft demonstrations.
    /// Demonstrations are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying draft demonstrations classes and building a catalogue of draft demonstrations.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftDemonstrationsMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsDemonstrations;
        /// <summary>
        /// Allows specifying that a class is *not* an demonstrations class.
        /// This is useful for marking classes that end up canonical demonstrations code file locations, but are not demonstrations classes.
        /// </summary>
        public bool IsDemonstrations
        {
            get
            {
                return this.zIsDemonstrations;
            }
        }


        public DraftDemonstrationsMarkerAttribute(
            bool isDemonstrations = true)
        {
            this.zIsDemonstrations = isDemonstrations;
        }
    }
}
