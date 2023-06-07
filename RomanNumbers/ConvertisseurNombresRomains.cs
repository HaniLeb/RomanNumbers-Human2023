namespace RomanNumbers;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffreArabe)
    {
        switch (chiffreArabe)
        {
            case <= 3:
                return new string('I', (int)chiffreArabe);
            case 4:
                return "IV";
            case 5:
            case 6:
            case 7:
            case 8:
                return "V" + Convertir(chiffreArabe - 5);
            case 9:
                return "IX";
            case 10:
            case 11:
            case 12:
            case 13:
                return "X" + Convertir(chiffreArabe - 10);
            case 14:
                return "XIV";
            case 15:
            case 16:
            case 17:
            case 18:
                return "XV" + Convertir(chiffreArabe - 15);
            case 19:
                return "XIX";
            case 20:
                return "XX";
            default:
                throw new ArgumentOutOfRangeException(nameof(chiffreArabe));
        }
    }
}
