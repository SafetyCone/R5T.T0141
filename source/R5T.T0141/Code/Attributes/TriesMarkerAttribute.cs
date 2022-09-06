using System;

using R5T.T0143;


namespace R5T.T0141
{
    /// <summary>
    /// <para>The usual Tries instance interface name is the singular 'Try'. Otherwise, tries instance interfaces names should be <b>TriesForX</b>.</para>
    /// Attribute indicating an interface contains tries.
    /// Tries are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying tries interfaces and building a catalogue of tries.
    /// Note: there is no draft tries marker since all tries are in a sense "drafts".
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class TriesMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsTry;
        /// <summary>
        /// Allows specifying that an interface is *not* a tries interface.
        /// This is useful for marking interfaces that end up in canonical tries code file locations, but are not tries interfaces.
        /// </summary>
        public bool IsTry
        {
            get
            {
                return this.zIsTry;
            }
        }


        public TriesMarkerAttribute(
            bool isTry = true)
        {
            this.zIsTry = isTry;
        }
    }
}
