using System.Text.RegularExpressions;

namespace StringValidationExtensions;
public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            return false;

        string PhonePattern = @"^(\+20|0020|020)?0?(10|11|12|15)\d{8}$";

        if (Regex.IsMatch(phoneNumber, PhonePattern))
            return true;

        else return false;
    }

    public static bool IsValidEgyptianNationalId(this string nationalId)
    {
        if (string.IsNullOrWhiteSpace(nationalId))
            return false;

        string NationalIDPattern = @"^[23]\d{2}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])\d{2}\d{4}\d$";

        if (Regex.IsMatch(nationalId, NationalIDPattern))
            return true;

        else return false;
    }
}
