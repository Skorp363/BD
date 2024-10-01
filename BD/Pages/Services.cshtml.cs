using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace BD.Pages
{
    public class ServicesModel : PageModel
    {
        /*public List<SearchResult> Results { get; set; } = new List<SearchResult>();

        public void OnGet(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return; // Выходим из метода, если нет запроса
            }

            // Пример статических страниц с содержимым
            var pages = new List<SearchResult>
            {
                new SearchResult
                {
                    Title = "Резисторы",
                    Url = "/Resistors",
                    Content = "Резисторы - это электронные компоненты, которые ограничивают электрический ток в цепи."
                },
                new SearchResult
                {
                    Title = "Конденсаторы",
                    Url = "/Capacitors",
                    Content = "Конденсаторы - это электронные компоненты, которые накапливают электрический заряд и могут использоваться для фильтрации, сглаживания и временной задержки сигналов."
                },
                new SearchResult
                {
                    Title = "Диоды",
                    Url = "/Diodes",
                    Content = "Диоды — это полупроводниковые устройства, которые позволяют току проходить в одном направлении и блокируют его в другом."
                },
                new SearchResult
                {
                    Title = "Транзисторы",
                    Url = "/Transistors",
                    Content = "Транзисторы — это полупроводниковые устройства, которые используются для усиления и переключения электрических сигналов."
                },
                new SearchResult
                {
                    Title = "Интегральные схемы",
                    Url = "/IntegratedCircuits",
                    Content = "Интегральные схемы (ИС) — это миниатюрные электронные устройства, которые объединяют множество компонентов на одной подложке."
                },
                new SearchResult
                {
                    Title = "Катушки индуктивности",
                    Url = "/Inductors",
                    Content = "Катушки индуктивности — это пассивные электронные компоненты, которые накапливают электрическую энергию в магнитном поле."
                },
                new SearchResult
                {
                    Title = "Трансформаторы",
                    Url = "/Transformers",
                    Content = "Трансформаторы — это электрические устройства, которые преобразуют переменное напряжение и ток, передавая энергию от одного цепи к другой."
                },
                new SearchResult
                {
                    Title = "Сенсоры и датчики",
                    Url = "/Sensors",
                    Content = "Сенсоры и датчики — это устройства, которые воспринимают физические величины и преобразуют их в электрические сигналы."
                },
                new SearchResult
                {
                    Title = "Микроконтроллеры",
                    Url = "/Microcontrollers",
                    Content = "Микроконтроллеры — это компактные вычислительные устройства, которые управляют электронными системами и процессами."
                },
            };

            // Поиск по заголовкам и содержимому
            Results = pages.Where(p =>
                p.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                p.Content.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }*/
    }
}

/*public class SearchResult
{
    public string Title { get; set; } = null!;
    public string Url { get; set; } = null!;
    public string Content { get; set; } = null!;
}*/
