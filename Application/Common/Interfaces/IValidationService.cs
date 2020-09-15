namespace Application.Common.Interfaces
{
    public interface IValidationService
    {
        bool IsValidNumber(string input, out int output);
        bool IsValidNumberOfPieces(int numberOfPieces);
    }
}