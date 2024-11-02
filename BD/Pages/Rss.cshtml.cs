using BD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace BD.Pages
{
    public class RssModel(ILogger<RssModel> logger, ApplicationContext db) : PageModel
    {
        private readonly ApplicationContext context = db;
        private readonly ILogger<RssModel> _logger = logger;

        public List<RssLink> Links { get; set; } = new List<RssLink>();

        [BindProperty]
        public RssLink Link { get; set; }
        public List<RssItem> FeedItems { get; set; } = new List<RssItem>();

        // Свойства для пользовательской новости
        [BindProperty]
        [Required(ErrorMessage = "Поле Title обязательно для заполнения.")]
        public string Title { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Поле Description обязательно для заполнения.")]
        public string Description { get; set; } = string.Empty;

        [BindProperty]
        public string? Author { get; set; }

        // Свойство для ввода RSS-ленты
        [BindProperty]
        [Url(ErrorMessage = "Некорректный формат URL.")]
        public string? RssLink { get; set; }

        public async void OnGetAsync()
        {
            
            Links = context.RssLinks.ToList();
            foreach (var link in Links)
            {
                RssLink = link.Link;
                OnPostAddRssFeed();
                
                
                
            }
            FeedItems = GetFeedItems();
        }

        public IActionResult OnPostAddUserNews()
        {
            // Создаем новый элемент RSS
            var newItem = new RssItem
            {
                Title = Title,
                Link = "", // Здесь вы можете добавить логику для получения ссылки
                Description = $"{Description} (Автор: {Author ?? "Неизвестно"})",
                PubDate = DateTime.Now
            };

            // Получаем существующие элементы RSS
            FeedItems = GetFeedItems();

            // Проверяем, существует ли элемент с таким же заголовком или ссылкой
            var existingItem = FeedItems.FirstOrDefault(item => item.Title.Equals(newItem.Title, StringComparison.OrdinalIgnoreCase));

            if (existingItem != null)
            {
                // Если существует, добавляем сообщение об ошибке
                TempData["ErrorMessage"] = "Новость с таким заголовком уже существует!"; // Замените на ErrorMessage
                return RedirectToPage();
            }

            // Добавляем новый элемент в список и обновляем RSS-ленту
            FeedItems.Add(newItem);
            UpdateRssFeed(FeedItems);

            // Сообщение об успешном добавлении
            TempData["Message"] = "Новость успешно добавлена!"; // Замените на Message

            return RedirectToPage();
        }



        public IActionResult OnPostAddRssFeed()
        {
            if (!string.IsNullOrEmpty(RssLink))
            {
                try
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                    // Сначала загружаем существующие записи
                    var existingItems = GetFeedItems();
                    var newItems = LoadRssFeed(RssLink);
                    

                    // Объединяем только уникальные записи
                    foreach (var newItem in newItems)
                    {
                        // Проверяем, существует ли уже запись
                        if (!existingItems.Any(existingItem => existingItem.Title == newItem.Title))
                        {
                            existingItems.Add(newItem);
                        }
                    }

                    

                    // Обновляем RSS-ленту с уникальными записями
                    UpdateRssFeed(existingItems);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка при загрузке RSS-ленты по ссылке {RssLink}", RssLink);
                }
            }
            return RedirectToPage();
        }


        private List<RssItem> GetFeedItems()
        {
            var items = new List<RssItem>();
            var rssPath = "wwwroot/rss/rss_news.xml";

            if (System.IO.File.Exists(rssPath))
            {
                try
                {
                    var rssDocument = XDocument.Load(rssPath);
                    var channel = rssDocument.Root?.Element("channel");

                    if (channel != null)
                    {
                        foreach (var itemElement in channel.Elements("item"))
                        {
                            var item = new RssItem
                            {
                                Title = itemElement.Element("title")?.Value ?? "Без заголовка",
                                Link = itemElement.Element("link")?.Value ?? "",
                                Description = itemElement.Element("description")?.Value ?? "Описание отсутствует",
                                PubDate = DateTime.TryParse(itemElement.Element("pubDate")?.Value, out var pubDate) ? pubDate : DateTime.Now
                            };
                            items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ошибка при загрузке RSS-ленты из файла {rssPath}", rssPath);
                }
            }
            return items.OrderByDescending(item => item.PubDate).ToList();
        }

        private List<RssItem> LoadRssFeed(string rssLink)
        {
            var items = new List<RssItem>();
            try
            {
                var rssDocument = XDocument.Load(rssLink);
                var channel = rssDocument.Root?.Element("channel");

                if (channel != null)
                {
                    foreach (var itemElement in channel.Elements("item"))
                    {
                        var item = new RssItem
                        {
                            Title = itemElement.Element("title")?.Value ?? "Без заголовка",
                            Link = itemElement.Element("link")?.Value ?? "",
                            Description = itemElement.Element("description")?.Value ?? "Описание отсутствует",
                            PubDate = DateTime.TryParse(itemElement.Element("pubDate")?.Value, out var pubDate) ? pubDate : DateTime.Now
                        };
                        items.Add(item);
                    }
                    Links = context.RssLinks.ToList();
                    Link = new RssLink { Link = rssLink };

                    var link = Links.Find(m => m.Link == rssLink);
                    if (link == null)
                    {
                        context.RssLinks.Add(Link);
                        context.SaveChangesAsync();
                        TempData["Message"] = "Новости по RSS-ссылке добавлены!";
                    }
                    
                    


                }
            }
            catch (XmlException ex)
            {
                TempData["ErrorMessage"] = "Ошибка: Неверный формат RSS-ленты. Пожалуйста, проверьте ссылку.";
                _logger.LogError(ex, "Ошибка при загрузке RSS-ленты по ссылке {rssLink}", rssLink);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Ошибка: Не удалось загрузить RSS-ленту. Проверьте соединение.";
                _logger.LogError(ex, "Ошибка при загрузке RSS-ленты по ссылке {rssLink}", rssLink);
            }
            return items;
        }

        private void UpdateRssFeed(List<RssItem> items)
        {
            XDocument rss = new XDocument(
                new XElement("rss", new XAttribute("version", "2.0"),
                    new XElement("channel",
                        from item in items
                        select new XElement("item",
                            new XElement("title", item.Title),
                            new XElement("link", item.Link),
                            new XElement("description", item.Description),
                            new XElement("pubDate", item.PubDate.ToString("g"))
                        )
                    )
                )
            );

            string filePath = "wwwroot/rss/rss_news.xml";
            try
            {
                rss.Save(filePath);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при сохранении RSS-ленты в файл {filePath}", filePath);
            }
        }
    }
}
