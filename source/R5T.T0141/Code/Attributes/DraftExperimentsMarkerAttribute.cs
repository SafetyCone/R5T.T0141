using System;


namespace R5T.T0141
{
    /// <summary>
    /// Attribute indicating an interface contains draft experiments.
    /// Experiments are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying draft experiments classes and building a catalogue of draft experiments.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class DraftExperimentsMarkerAttribute : Attribute
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


        public DraftExperimentsMarkerAttribute(
            bool isExperiments = true)
        {
            this.zIsExperiments = isExperiments;
        }
    }
}
