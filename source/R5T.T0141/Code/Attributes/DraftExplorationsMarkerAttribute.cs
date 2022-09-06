using System;

using R5T.T0143;


namespace R5T.T0141
{
    /// <summary>
    /// Attribute indicating an interface contains draft explorations.
    /// Explorations are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying draft explorations classes and building a catalogue of draft explorations.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftExplorationsMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsExplorations;
        /// <summary>
        /// Allows specifying that a class is *not* an explorations class.
        /// This is useful for marking classes that end up canonical explorations code file locations, but are not explorations classes.
        /// </summary>
        public bool IsExplorations
        {
            get
            {
                return this.zIsExplorations;
            }
        }


        public DraftExplorationsMarkerAttribute(
            bool isExplorations = true)
        {
            this.zIsExplorations = isExplorations;
        }
    }
}
