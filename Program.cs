namespace RS3_ZamorakBLM;
public static class EnrageData{

    public sealed record EnrageBracket(
        int Enrage,
        int Decrement,
        int BaseDenominator,
        int MaximumDenominator
        );
    public static readonly EnrageBracket[] Brackets =
        [
            new(Enrage: 100,  Decrement: 1,  BaseDenominator: 80, MaximumDenominator: 20),
            new(Enrage: 150,  Decrement: 1,  BaseDenominator: 77, MaximumDenominator: 20),
            new(Enrage: 200,  Decrement: 1,  BaseDenominator: 72, MaximumDenominator: 20),
            new(Enrage: 300,  Decrement: 1,  BaseDenominator: 67, MaximumDenominator: 20),
            new(Enrage: 400,  Decrement: 1,  BaseDenominator: 62, MaximumDenominator: 20),
            new(Enrage: 500,  Decrement: 1,  BaseDenominator: 52, MaximumDenominator: 20),
            new(Enrage: 750,  Decrement: 1,  BaseDenominator: 47, MaximumDenominator: 20),
            new(Enrage: 900,  Decrement: 1,  BaseDenominator: 40, MaximumDenominator: 20),
            new(Enrage: 1000, Decrement: 1,  BaseDenominator: 37, MaximumDenominator: 20),
            new(Enrage: 1250, Decrement: 1,  BaseDenominator: 35, MaximumDenominator: 10),
            new(Enrage: 1500, Decrement: 1,  BaseDenominator: 31, MaximumDenominator: 10),
            new(Enrage: 2000, Decrement: 1,  BaseDenominator: 28, MaximumDenominator: 5 ),
        ];
}