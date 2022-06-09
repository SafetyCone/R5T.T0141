using System;


namespace R5T.T0141
{
    /// <summary>
    /// <para>Explorations instance interface names should be <b>plural</b>. This is so "IString" and "String" does not class with "String" from system.</para>
    /// Attribute indicating an interface contains explorations.
    /// Explorations are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying explorations classes and building a catalogue of explorations.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class ExplorationsMarkerAttribute : Attribute
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


        public ExplorationsMarkerAttribute(
            bool isExplorations = true)
        {
            this.zIsExplorations = isExplorations;
        }
    }
}
