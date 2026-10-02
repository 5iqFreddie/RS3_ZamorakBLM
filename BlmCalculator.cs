namespace RS3_ZamorakBLM;

public static class BlmCalculator
{
    public static int CalcDropRate(
        int accumulatedBLM,
        EnrageBracket enrageBracket)
        {
            return Math.Max(enrageBracket.BaseChance - accumulatedBLM,
                enrageBracket.MaximumChance);
        }
}
