using System;


namespace R5T.T0141
{
    /// <summary>
    /// <para>Experiments instance interface names should be <b>plural</b>. This is so "IString" and "String" does not class with "String" from system.</para>
    /// Attribute indicating an interface contains experiments.
    /// Experiments are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying experiments classes and building a catalogue of experiments.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class ExperimentsMarkerAttribute : Attribute
    {
        private readonly bool zIsExperiments;
        /// <summary>
        /// Allows specifying that a class is *not* an experiments class.
        /// This is useful for marking classes that end up canonical experiments code file locations, but are not experiments classes.
        /// </summary>
        public bool IsExperiments
        {
            get
            {
                return this.zIsExperiments;
            }
        }


        public ExperimentsMarkerAttribute(
            bool isExperiments = true)
        {
            this.zIsExperiments = isExperiments;
        }
    }
}
