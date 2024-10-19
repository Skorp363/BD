using Microsoft.EntityFrameworkCore;

namespace BD.Models
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Details> Details { get; set; } = null!;
		public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
		public DbSet<Material> Materials { get; set; } = null!;
		public DbSet<Type> Types { get; set; } = null!;
		public DbSet<Country> Countries { get; set; }
		public DbSet<User> Users { get; set; } = null!;
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
			
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Country>().HasData(
				new Country { Id = 1, Code = "TW", Name = "Тайвань" },
				new Country { Id = 2, Code = "CN", Name = "Китай" },
				new Country { Id = 3, Code = "RU", Name = "Россия" },
				new Country { Id = 4, Code = "DE", Name = "Германия" },
				new Country { Id = 5, Code = "JP", Name = "Япония" },
				new Country { Id = 6, Code = "US", Name = "США" },
				new Country { Id = 7, Code = "CH", Name = "Швейцария" }
				);
			modelBuilder.Entity<Type>().HasData(
				new Type { Id = 1, Code = 1, Name = "Активный" },
				new Type { Id = 2, Code = 2, Name = "Пассивный" },
				new Type { Id = 3, Code = 3, Name = "Подстроечный" }
				);
			modelBuilder.Entity<Manufacturer>().HasData(
				new Manufacturer { Id = 1, Name = "BOURNS", Address = "Риверсайд, Калифорния", Country = "США", Director = "Гордон Борнс", Activity = "Electronics" },
				new Manufacturer { Id = 2, Name = "JB Capacitors", Address = "г. Хэфей, провинция Аньхой, КНР; г. Дунгуан, провинция Гуаньдун.", Country = "Китай", Phone = "+8-522-790-50-91", Activity = "Electronics" },
				new Manufacturer { Id = 3, Name = "Kemet Electronics", Address = "Форт-Лодердейл, Флорида", Country = "США", Activity = "Electronics" },
				new Manufacturer { Id = 4, Name = "EPCOS", Address = "Мюнхен", Country = "Германия", Activity = "Electronics" },
				new Manufacturer { Id = 5, Name = "Murata Electronics", Address = "Нагаокакё, Киото", Country = "Япония", Director = "Норио Накадзима", Activity = "Electronics" },
				new Manufacturer { Id = 6, Name = "ON Semiconductor", Address = " Финикс, Аризона", Country = "США", Director = "Хассан Эль-Хури", Activity = "Electronics" },
				new Manufacturer { Id = 7, Name = "STMicroelectronics", Address = "Женева", Country = "Швейцария", Director = "Жан-Марк Чери, Remi El-Ouazzane", Activity = "Electronics" },
				new Manufacturer { Id = 8, Name = "Analog Devices", Address = "Уилмингтон, Массачусетс", Country = "США", Director = "Венсан Рош", Activity = "Semiconductor" },
				new Manufacturer { Id = 9, Name = "Song Huei Electronic", Address = "4F-1, № 288-7, ShinYa Road, район Чиен Чен, Гаосюн, 80673", Country = "Тайвань", Phone = "+8-867-815-00-38", Activity = "Electronics" },
				new Manufacturer { Id = 10, Name = "ОАО \"Радиодеталь\"", Address = "431110, Республика Мордовия, п. Зубова Поляна, ул. Новикова-Прибоя, 35.", Country = "Россия", Phone = "+7-834-582-11-50", Director = "Казеев Александр Александрович", Activity = "Electronics" }
				);
			modelBuilder.Entity<Material>().HasData(
				new Material { Id = 1, Code = 1, Name = "Металлокерамика" },
				new Material { Id = 2, Code = 2, Name = "Углерод" },
				new Material { Id = 3, Code = 3, Name = "Керамика" },
				new Material { Id = 4, Code = 4, Name = "Бумага" },
				new Material { Id = 5, Code = 5, Name = "Плёнка" },
				new Material { Id = 6, Code = 6, Name = "Медь" },
				new Material { Id = 7, Code = 7, Name = "Феррит" },
				new Material { Id = 8, Code = 8, Name = "Кварц" },
				new Material { Id = 9, Code = 9, Name = "Полипропилен" },
				new Material { Id = 10, Code = 10, Name = "Стекло" }
				);
			modelBuilder.Entity<Details>().HasData(
				new Details { Id = 1, Name = "Резистор углеродистый", Price = 9, CountryId = 1, Part_typeId = 2, Model = "CF-100", Operating_voltage = 500, MinOperating_Temp = -55, MaxOperating_Temp = 155, Power = 1, Resistance = 1, ManufacturerId = 1, MaterialId = 2 },
				new Details { Id = 2, Name = "Резистор углеродистый", Price = 9, CountryId = 1, Part_typeId = 2, Model = "CF-100", Operating_voltage = 500, MinOperating_Temp = -55, MaxOperating_Temp = 155, Power = 1, Resistance = 100, ManufacturerId = 1, MaterialId = 2 },
				new Details { Id = 3, Name = "Резистор углеродистый", Price = 9, CountryId = 1, Part_typeId = 2, Model = "CF-100", Operating_voltage = 500, MinOperating_Temp = -55, MaxOperating_Temp = 155, Power = 1, Resistance = 510, ManufacturerId = 1, MaterialId = 2 },
				new Details { Id = 4, Name = "Резистор силовой", Price = 1540, CountryId = 1, Part_typeId = 2, Model = "AH-100", Operating_voltage = 1900, MinOperating_Temp = -55, MaxOperating_Temp = 275, Power = 100, Resistance = 0.1, ManufacturerId = 3, MaterialId = 2 },
				new Details { Id = 5, Name = "Резистор силовой", Price = 1530, CountryId = 1, Part_typeId = 2, Model = "AH-100", Operating_voltage = 1900, MinOperating_Temp = -55, MaxOperating_Temp = 275, Power = 100, Resistance = 1.5, ManufacturerId = 3, MaterialId = 2 },
				new Details { Id = 6, Name = "Резистор силовой", Price = 1540, CountryId = 1, Part_typeId = 2, Model = "AH-100", Operating_voltage = 1900, MinOperating_Temp = -55, MaxOperating_Temp = 275, Power = 100, Resistance = 1000, ManufacturerId = 3, MaterialId = 2 },
				new Details { Id = 7, Name = "Резистор подстроечный", Price = 150, CountryId = 1, Part_typeId = 3, Model = "3006", Operating_voltage = 1000, MinOperating_Temp = -55, MaxOperating_Temp = 125, Power = 0.75, Resistance = 100, ManufacturerId = 1, MaterialId = 1 },
				new Details { Id = 8, Name = "Резистор подстроечный", Price = 200, CountryId = 1, Part_typeId = 3, Model = "3224", Operating_voltage = 600, MinOperating_Temp = -65, MaxOperating_Temp = 150, Power = 0.25, Resistance = 1000, ManufacturerId = 1, MaterialId = 1 },
				new Details { Id = 9, Name = "Резистор подстроечный", Price = 220, CountryId = 1, Part_typeId = 3, Model = "3266", Operating_voltage = 600, MinOperating_Temp = -65, MaxOperating_Temp = 150, Power = 0.25, Resistance = 50, ManufacturerId = 1, MaterialId = 1 },
				new Details { Id = 10, Name = "Конденсатор керамический дисковый", Price = 15, CountryId = 2, Part_typeId = 2, Model = "JYC", Operating_voltage = 2000, MinOperating_Temp = -25, MaxOperating_Temp = 85, Capacity = 0.1, ManufacturerId = 2, MaterialId = 3 },
				new Details { Id = 11, Name = "Конденсатор бумажный", Price = 330, CountryId = 1, Part_typeId = 2, Operating_voltage = 500, MinOperating_Temp = -40, MaxOperating_Temp = 100, Capacity = 2.2, ManufacturerId = 3, MaterialId = 4 },
				new Details { Id = 12, Name = "Конденсатор бумажный", Price = 210, CountryId = 4, Part_typeId = 2, Model = "ОМБГ-3", Operating_voltage = 400, MinOperating_Temp = -60, MaxOperating_Temp = 60, Capacity = 0.25, ManufacturerId = 4, MaterialId = 4 },
				new Details { Id = 13, Name = "Конденсатор металлоплёночный", Price = 10, CountryId = 2, Part_typeId = 2, Model = "JFA", Operating_voltage = 100, MinOperating_Temp = -45, MaxOperating_Temp = 85, Capacity = 1, ManufacturerId = 2, MaterialId = 5 },
				new Details { Id = 14, Name = "Конденсатор металлоплёночный", Price = 33, CountryId = 3, Part_typeId = 2, Model = "полиэстер", Operating_voltage = 63, MinOperating_Temp = -60, MaxOperating_Temp = 125, Capacity = 180, ManufacturerId = 10, MaterialId = 5 },
				new Details { Id = 15, Name = "Конденсатор плёночный", Price = 1330, CountryId = 4, Part_typeId = 2, Model = "b32320i", Operating_voltage = 350, MinOperating_Temp = -25, MaxOperating_Temp = 65, Capacity = 65000, ManufacturerId = 4, MaterialId = 5 },
				new Details { Id = 16, Name = "Конденсатор подстроечный", Price = 200, CountryId = 5, Part_typeId = 3, Model = "tzc3", Operating_voltage = 100, MinOperating_Temp = -25, MaxOperating_Temp = 85, Capacity = 0.0125, ManufacturerId = 5, MaterialId = 5 },
				new Details { Id = 17, Name = "Конденсатор подстроечный", Price = 280, CountryId = 2, Part_typeId = 3, Model = "tzc3", Operating_voltage = 100, MinOperating_Temp = -25, MaxOperating_Temp = 85, Capacity = 0.0022, ManufacturerId = 6, MaterialId = 3 },
				new Details { Id = 18, Name = "Индуктивный элемент", Price = 15, CountryId = 2, Part_typeId = 2, Model = "ec24", MinOperating_Temp = -20, MaxOperating_Temp = 100, Resistance = 0.72, Electric_current = 0.37, Inductance = 0.01, ManufacturerId = 6, MaterialId = 6 },
				new Details { Id = 19, Name = "Катушка индуктивности", Price = 110, CountryId = 3, Part_typeId = 2, Model = "киг", MinOperating_Temp = -20, MaxOperating_Temp = 100, Resistance = 11, Electric_current = 0.2, Inductance = 0.047, ManufacturerId = 10, MaterialId = 6 },
				new Details { Id = 20, Name = "Катушка индуктивности", Price = 530, CountryId = 4, Part_typeId = 2, MinOperating_Temp = -40, MaxOperating_Temp = 125, Electric_current = 0.025, Inductance = 0.01, ManufacturerId = 4, MaterialId = 6 },
				new Details { Id = 21, Name = "Индуктивность SMD", Price = 31, CountryId = 1, Part_typeId = 2, Model = "cm322522", MinOperating_Temp = -20, MaxOperating_Temp = 100, Resistance = 2.1, Inductance = 0.01, ManufacturerId = 1, MaterialId = 6 },
				new Details { Id = 22, Name = "Индуктивность для подавления ЭПМ", Price = 49, CountryId = 5, Part_typeId = 2, Model = "bla", Resistance = 600, Electric_current = 0.1, Inductance = 30, ManufacturerId = 5, MaterialId = 6 },
				new Details { Id = 23, Name = "Фильтр подавления ЭПМ", Price = 170, CountryId = 5, Part_typeId = 2, Model = "pla", Operating_voltage = 300, MinOperating_Temp = -25, MaxOperating_Temp = 60, Electric_current = 0.3, Inductance = 36, ManufacturerId = 5, MaterialId = 6 },
				new Details { Id = 24, Name = "Дроссель: проволочный", Price = 270, CountryId = 4, Part_typeId = 2, Model = "RF", MinOperating_Temp = -55, MaxOperating_Temp = 125, Resistance = 4.14, Electric_current = 0.33, Inductance = 2.7, ManufacturerId = 4, MaterialId = 7 },
				new Details { Id = 25, Name = "Дроссель силовой", Price = 980, CountryId = 4, Part_typeId = 2, Model = "b82615", Operating_voltage = 250, Resistance = 0.5, Electric_current = 2, Inductance = 5, ManufacturerId = 4, MaterialId = 7 },
				new Details { Id = 26, Name = "Дроссель", Price = 1210, CountryId = 4, Part_typeId = 2, Model = "b82625", Operating_voltage = 250, Resistance = 0.072, Electric_current = 5, Inductance = 0.25, ManufacturerId = 4, MaterialId = 7 },
				new Details { Id = 27, Name = "Чип резистор (SMD)", Price = 6, CountryId = 2, Part_typeId = 2, Model = "smd 0402", Operating_voltage = 50, MinOperating_Temp = -55, MaxOperating_Temp = 155, Power = 0.062, Resistance = 1.2, ManufacturerId = 6, MaterialId = 2 },
				new Details { Id = 28, Name = "Кварцевый генератор", Price = 300, CountryId = 1, Part_typeId = 2, Operating_voltage = 5, MinOperating_Temp = 0, MaxOperating_Temp = 70, Electric_current = 0.02, ManufacturerId = 1, MaterialId = 8 },
				new Details { Id = 29, Name = "Конденсатор подавления ЭМП", Price = 50, CountryId = 4, Part_typeId = 2, Model = "b32022", Operating_voltage = 300, MinOperating_Temp = -40, MaxOperating_Temp = 110, Capacity = 1.5, ManufacturerId = 4, MaterialId = 9 },
				new Details { Id = 30, Name = "Конденсатор танталовый SMD", Price = 28, CountryId = 1, Part_typeId = 2, Operating_voltage = 35, MinOperating_Temp = -55, MaxOperating_Temp = 125, Capacity = 1000, ManufacturerId = 9, MaterialId = 9 },
				new Details { Id = 31, Name = "Импульсный регулятор напряжения", Price = 580, CountryId = 2, Part_typeId = 1, Model = "fscq", Operating_voltage = 650, MinOperating_Temp = -25, MaxOperating_Temp = 85, Power = 210, ManufacturerId = 6, MaterialId = 6 },
				new Details { Id = 32, Name = "ШИМ-контроллер со встроенным силовым ключом", Price = 180, CountryId = 2, Part_typeId = 1, Model = "viper", Operating_voltage = 730, MinOperating_Temp = -40, MaxOperating_Temp = 150, Power = 8, ManufacturerId = 7, MaterialId = 7 },
				new Details { Id = 33, Name = "Аттенюатор", Price = 2540, CountryId = 6, Part_typeId = 1, Model = "HMC273A", Operating_voltage = 5, MinOperating_Temp = -40, MaxOperating_Temp = 85, Power = 1, Resistance = 50, ManufacturerId = 8, MaterialId = 7 },
				new Details { Id = 34, Name = "Аттенюатор", Price = 2530, CountryId = 6, Part_typeId = 1, Model = "HMC658G", Operating_voltage = 5, MinOperating_Temp = -40, MaxOperating_Temp = 85, Power = 0.316, Resistance = 50, ManufacturerId = 8, MaterialId = 7 }, 
				new Details { Id = 35, Name = "Быстродействующий прецизионный компаратор напряжения", Price = 2700, CountryId = 6, Part_typeId = 1, Model = "AD790JNZ", Operating_voltage = 4, MinOperating_Temp = 0, MaxOperating_Temp = 70, Electric_current = 0.01, ManufacturerId = 8, MaterialId = 6 },
				new Details { Id = 36, Name = "Дифференциальный компаратор со стробированием", Price = 53, CountryId = 2, Part_typeId = 1, Model = "LM211DT", Operating_voltage = 15, MinOperating_Temp = -40, MaxOperating_Temp = 85, Electric_current = 0.006, ManufacturerId = 7, MaterialId = 3 },
				new Details { Id = 37, Name = "Маломощный квадрантный компаратор напряжения", Price = 34, CountryId = 5, Part_typeId = 1, Model = "LM2901DT", Operating_voltage = 15, MinOperating_Temp = 0, MaxOperating_Temp = 70, Electric_current = 0.002, ManufacturerId = 5, MaterialId = 3 },
				new Details { Id = 38, Name = "Конденсатор пусковой", Price = 240, CountryId = 2, Part_typeId = 2, Model = "CBB61", Operating_voltage = 450, MinOperating_Temp = -40, MaxOperating_Temp = 70, Capacity = 5000, ManufacturerId = 6, MaterialId = 9 },
				new Details { Id = 39, Name = "Резистор прецизионный многооборотный", Price = 5700, CountryId = 1, Part_typeId = 2, Model = "3540s", MinOperating_Temp = 1, MaxOperating_Temp = 125, Power = 2, Resistance = 1000, ManufacturerId = 1, MaterialId = 3 },
				new Details { Id = 40, Name = "Резистор переменный", Price = 150, CountryId = 1, Part_typeId = 2, Model = "r24n1", Operating_voltage = 500, MinOperating_Temp = -10, MaxOperating_Temp = 70, Power = 0.5, Resistance = 1000, ManufacturerId = 9, MaterialId = 3 },
				new Details { Id = 41, Name = "Резистор переменный", Price = 97, CountryId = 1, Part_typeId = 2, Model = "rk-1112n", Operating_voltage = 50, MinOperating_Temp = -10, MaxOperating_Temp = 70, Power = 0.05, Resistance = 1000, ManufacturerId = 9, MaterialId = 3 },
				new Details { Id = 42, Name = "Конденсатор керамический выводной", Price = 7, CountryId = 4, Part_typeId = 2, Model = "к10-17б", Operating_voltage = 50, MinOperating_Temp = -55, MaxOperating_Temp = 125, Capacity = 0.012, ManufacturerId = 4, MaterialId = 3 },
				new Details { Id = 43, Name = "Предохранитель стеклянный быстродействующий", Price = 15, CountryId = 1, Part_typeId = 2, Operating_voltage = 250, MinOperating_Temp = -65, MaxOperating_Temp = 85, Electric_current = 0.5, ManufacturerId = 9, MaterialId = 10 },
				new Details { Id = 44, Name = "Предохранитель", Price = 30, CountryId = 3, Part_typeId = 2, Operating_voltage = 250, MinOperating_Temp = -60, MaxOperating_Temp = 85, Electric_current = 0.63, ManufacturerId = 10, MaterialId = 10 },
				new Details { Id = 45, Name = "Предохранитель", Price = 54, CountryId = 3, Part_typeId = 2, Operating_voltage = 600, MinOperating_Temp = -60, MaxOperating_Temp = 100, Electric_current = 5, ManufacturerId = 10, MaterialId = 10 },
				new Details { Id = 46, Name = "Предохранитель керамический", Price = 33, CountryId = 5, Part_typeId = 2, Operating_voltage = 250, MinOperating_Temp = -60, MaxOperating_Temp = 100, Electric_current = 4, ManufacturerId = 5, MaterialId = 3 },
				new Details { Id = 47, Name = "Предохранитель керамический", Price = 26, CountryId = 3, Part_typeId = 2, Operating_voltage = 350, MinOperating_Temp = -60, MaxOperating_Temp = 70, Electric_current = 0.1, ManufacturerId = 10, MaterialId = 3 },
				new Details { Id = 48, Name = "Предохранитель самовосстанавливающийся", Price = 38, CountryId = 1, Part_typeId = 2, Model = "MF-R020", Operating_voltage = 60, MinOperating_Temp = -40, MaxOperating_Temp = 85, Power = 0.4, Resistance = 2.2, Electric_current = 40, ManufacturerId = 1, MaterialId = 3 },
				new Details { Id = 49, Name = "Плавкий предохранитель", Price = 130, CountryId = 1, Part_typeId = 2, Model = "SF-1206SxxxM", Operating_voltage = 63, MinOperating_Temp = -55, MaxOperating_Temp = 125, Resistance = 50, Electric_current = 2, ManufacturerId = 1, MaterialId = 6 },
				new Details { Id = 50, Name = "Резистор углеродистый", Price = 9, CountryId = 1, Part_typeId = 2, Model = "CF-50", Operating_voltage = 350, MinOperating_Temp = -55, MaxOperating_Temp = 155, Power = 0.5, Resistance = 510, ManufacturerId = 1, MaterialId = 2 }

				);
		}
	}
}
