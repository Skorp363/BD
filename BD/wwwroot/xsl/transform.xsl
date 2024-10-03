<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method="html" encoding="UTF-8" indent="yes" />

	<xsl:template match="/">
		<script src="js/XSL.js"></script>
		<h1>Кухонные приборы</h1>
		<input type="text" id="searchInput" onkeyup="searchTable()" placeholder="Поиск..." />
		<a href="xml/KitchenAppliances.xml" class="href-xml">Открыть XML файл</a>
		<table id="appliancesTable" border="1">
			<tr>
				<th onclick="sortTable(0)">
					Название <span class="sort-arrow"></span>
				</th>
				<th onclick="sortTable(1)">
					Модель <span class="sort-arrow"></span>
				</th>
				<th onclick="sortTable(2)">
					Мощность, W <span class="sort-arrow"></span>
				</th>
				<th onclick="sortTable(3)">
					Напряжение, V <span class="sort-arrow"></span>
				</th>
				<th onclick="sortTable(4)">
					Цвет <span class="sort-arrow"></span>
				</th>
				<th onclick="sortTable(5)">
					Вес, kg <span class="sort-arrow"></span>
				</th>
				<th onclick="sortTable(6)">
					Размеры, cm <span class="sort-arrow"></span>
				</th>
				<th onclick="sortTable(7)">
					Энергетический класс <span class="sort-arrow"></span>
				</th>
				<th onclick="sortTable(8)">
					Год производства <span class="sort-arrow"></span>
				</th>
				<th onclick="sortTable(9)">
					Страна <span class="sort-arrow"></span>
				</th>
			</tr>

			<xsl:for-each select="appliances/appliance">
				<tr>
					<td>
						<xsl:value-of select="name" />
					</td>
					<td>
						<xsl:value-of select="model" />
					</td>
					<td>
						<xsl:value-of select="power" />
					</td>
					<td>
						<xsl:value-of select="voltage" />
					</td>
					<td>
						<xsl:value-of select="color" />
					</td>
					<td>
						<xsl:value-of select="weight" />
					</td>
					<td>
						<xsl:value-of select="dimensions" />
					</td>
					<td>
						<xsl:value-of select="energyClass" />
					</td>
					<td>
						<xsl:value-of select="manufactureYear" />
					</td>
					<td>
						<xsl:value-of select="country" />
					</td>
				</tr>
			</xsl:for-each>
		</table>
		<br />
	</xsl:template>
</xsl:stylesheet>
