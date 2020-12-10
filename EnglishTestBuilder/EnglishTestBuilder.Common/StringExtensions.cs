using EnglishTestBuilder.Models.Enums;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EnglishTestBuilder.Common
{
    public static class StringExtensions
    {
        public static List<WordType> ConvertToWordType(this string input)
        {
            var result = new List<WordType>();
            var wordTypes = input.ToLower().Split(',');
            foreach (var wordType in wordTypes)
            {
                WordType type;
                switch (wordType)
                {
                    case "v":
                    case "verb":
                        type = WordType.Verb;
                        break;
                    case "n":
                    case "noun":
                        type = WordType.Noun;
                        break;
                    case "a":
                    case "adj":
                        type = WordType.Adjective;
                        break;
                    case "adv":
                        type = WordType.Adverb;
                        break;
                    default:
                        type = WordType.Unknow;
                        ErrorMemoryStorage.AddError($"WordType {input} is not defined.");
                        break;
                }
                if (type != WordType.Unknow)
                    result.Add(type);
            }
            return result;
        }

        public static string RemoveSpecialString(this string input, string keepString = "(),")
        {
            var pattern = $"[^{keepString}a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+";
            var result = Regex.Replace(input, pattern, "");
            return result;
        }

        public static string RemoveSpecialStringForVN(this string input)
        {
            return input.RemoveSpecialString(" ,.").Trim();
        }
    }
}
