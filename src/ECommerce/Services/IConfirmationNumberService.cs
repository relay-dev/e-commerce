namespace ECommerce.Services
{
    public interface IConfirmationNumberService
    {
        /// <summary>
        /// Generates a string of random alphanumeric characters to be used as a confirmation number
        /// </summary>
        /// <param name="length">The desired length of the confirmation number</param>
        /// <param name="prefix">Optional: if provided, this string will be prepended to the confirmation number</param>
        /// <param name="suffix">Optional: if provided, this string will be appended to the confirmation number</param>
        /// <returns>The confirmation number generated</returns>
        string GenerateConfirmationNumber(int length, string prefix = null, string suffix = null);
    }
}
