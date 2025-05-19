namespace Content.Server.Pathogens
{
    [RegisterComponent]
    public sealed partial class TransmissibleComponent : Component
    {
        /// <summary>
        /// Spreads through touch (e.g. containers, food, hugs)
        /// </summary>
        [DataField]
        public bool SpreadsThroughTouch = true;

        /// <summary>
        /// Spreads through fluids (e.g. blood, vomit)
        /// </summary>
        [DataField]
        public bool SpreadsThroughFluids = true;

        /// <summary>
        /// Spreads through the air (proximity)
        /// </summary>
        [DataField]
        public bool SpreadsThroughAir = true;
    }
}
