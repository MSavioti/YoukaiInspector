using System;

namespace YoukaiFox.Inspector
{
    /// <summary>
    /// Hide the field if it is in Play Mode.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public sealed class HideInPlayModeAttribute : YoukaiAttribute
    {
    }
}