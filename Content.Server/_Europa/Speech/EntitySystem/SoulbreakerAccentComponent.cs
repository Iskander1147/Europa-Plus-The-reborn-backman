namespace Content.Server._Europa.Speech
{
    [RegisterComponent]
    public sealed partial class SoulbreakerAccentComponent : Component
    {
        [DataField("invocationChance")]
        public float InvocationChance = 0.35f;

        [DataField("greetingChance")]
        public float GreetingChance = 0.25f;

        [DataField("sufferingChance")]
        public float SufferingChance = 0.2f;
    }
}
