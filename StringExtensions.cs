using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace QLBH // dùng đúng namespace bạn đang dùng
{
    public static class StringExtensions
    {
        public static string GenerateSlug(this string phrase)
        {
            if (string.IsNullOrEmpty(phrase)) return "";

            // Chuyển sang lowercase và loại bỏ dấu
            string normalized = phrase.ToLowerInvariant().Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark && (char.IsLetterOrDigit(c) || c == ' '))
                {
                    sb.Append(c);
                }
            }

            string slug = sb.ToString().Normalize(NormalizationForm.FormC);

            // Đổi khoảng trắng thành dấu gạch ngang
            slug = Regex.Replace(slug, @"\s+", "-");

            return slug;
        }
    }
}
