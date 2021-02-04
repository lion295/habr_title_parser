using AngleSharp.Html.Dom;

namespace Parser.Core
{
    interface IParser<T> where T : class // класс описыывающий интерфейс
    {
        T Parse(IHtmlDocument document);

    }
}
