using System;


namespace R5T.T0141
{
    /// <summary>
    /// <para>Demonstrations instance interface names should be <b>plural</b>. This is so "IString" and "String" does not class with "String" from system.</para>
    /// Attribute indicating an interface contains demonstrations.
    /// Demonstrations are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying demonstrations classes and building a catalogue of demonstrations.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class DemonstrationsMarkerAttribute : Attribute
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


        public DemonstrationsMarkerAttribute(
            bool isDemonstrations = true)
        {
            this.zIsDemonstrations = isDemonstrations;
        }
    }
}
