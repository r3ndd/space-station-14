namespace Content.Server.Pathogens
{
    [RegisterComponent]
    public sealed partial class PathogenReservoirComponent : Component
    {
        /// <summary>
        /// A list of virus entities that are in this reservoir
        /// </summary>
        [DataField]
        public List<EntityUid> Viruses = new();
    }
}
