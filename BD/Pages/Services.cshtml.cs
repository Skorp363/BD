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
                return; // ������� �� ������, ���� ��� �������
            }

            // ������ ����������� ������� � ����������
            var pages = new List<SearchResult>
            {
                new SearchResult
                {
                    Title = "���������",
                    Url = "/Resistors",
                    Content = "��������� - ��� ����������� ����������, ������� ������������ ������������� ��� � ����."
                },
                new SearchResult
                {
                    Title = "������������",
                    Url = "/Capacitors",
                    Content = "������������ - ��� ����������� ����������, ������� ����������� ������������� ����� � ����� �������������� ��� ����������, ����������� � ��������� �������� ��������."
                },
                new SearchResult
                {
                    Title = "�����",
                    Url = "/Diodes",
                    Content = "����� � ��� ����������������� ����������, ������� ��������� ���� ��������� � ����� ����������� � ��������� ��� � ������."
                },
                new SearchResult
                {
                    Title = "�����������",
                    Url = "/Transistors",
                    Content = "����������� � ��� ����������������� ����������, ������� ������������ ��� �������� � ������������ ������������� ��������."
                },
                new SearchResult
                {
                    Title = "������������ �����",
                    Url = "/IntegratedCircuits",
                    Content = "������������ ����� (��) � ��� ����������� ����������� ����������, ������� ���������� ��������� ����������� �� ����� ��������."
                },
                new SearchResult
                {
                    Title = "������� �������������",
                    Url = "/Inductors",
                    Content = "������� ������������� � ��� ��������� ����������� ����������, ������� ����������� ������������� ������� � ��������� ����."
                },
                new SearchResult
                {
                    Title = "��������������",
                    Url = "/Transformers",
                    Content = "�������������� � ��� ������������� ����������, ������� ����������� ���������� ���������� � ���, ��������� ������� �� ������ ���� � ������."
                },
                new SearchResult
                {
                    Title = "������� � �������",
                    Url = "/Sensors",
                    Content = "������� � ������� � ��� ����������, ������� ������������ ���������� �������� � ����������� �� � ������������� �������."
                },
                new SearchResult
                {
                    Title = "����������������",
                    Url = "/Microcontrollers",
                    Content = "���������������� � ��� ���������� �������������� ����������, ������� ��������� ������������ ��������� � ����������."
                },
            };

            // ����� �� ���������� � �����������
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
