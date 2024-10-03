window.onload = () => sortTable(0, true);

// Функция для сортировки таблицы
function sortTable(n, initial = false) {
    const table = document.getElementById("appliancesTable");
    let rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
    switching = true;
    dir = "asc"; // Направление сортировки: "asc" (по возрастанию) или "desc" (по убыванию)

    const headers = table.getElementsByTagName("th");
    Array.from(headers).forEach((th, index) => {
        th.classList.remove("active", "sort-asc", "sort-desc");
        if (index === n) {
            th.classList.add("active");
            th.classList.add(dir === "asc" ? "sort-asc" : "sort-desc");
        }
    });

    while (switching) {
        switching = false;
        rows = table.rows;

        for (i = 1; i < (rows.length - 1); i++) {
            shouldSwitch = false;
            x = rows[i].getElementsByTagName("TD")[n];
            y = rows[i + 1].getElementsByTagName("TD")[n];

            if (n === 6) { // Сортировка по размерам (столбец "Размеры")
                if (compareSizes(x.innerHTML, y.innerHTML, dir)) {
                    shouldSwitch = true;
                    break;
                }
            } else if (n === 7) { // Сортировка по энергетическому классу
                if (compareEnergyClass(x.innerHTML, y.innerHTML, dir)) {
                    shouldSwitch = true;
                    break;
                }
            } else if (!isNaN(x.innerHTML) && !isNaN(y.innerHTML)) { // Сортировка чисел
                if (compareNumbers(x.innerHTML, y.innerHTML, dir)) {
                    shouldSwitch = true;
                    break;
                }
            } else { // Сортировка текста
                if (compareStrings(x.innerHTML, y.innerHTML, dir)) {
                    shouldSwitch = true;
                    break;
                }
            }
        }

        if (shouldSwitch) {
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
            switchcount++;
        } else {
            if (switchcount === 0 && dir === "asc") {
                dir = "desc";
                switching = true;
                headers[n].classList.remove("sort-asc");
                headers[n].classList.add("sort-desc");
            }
        }
    }
}

// Функция для сравнения размеров
function compareSizes(a, b, dir) {
    const sizeA = a.split('x').map(Number);
    const sizeB = b.split('x').map(Number);

    for (let i = 0; i < sizeA.length; i++) {
        if (sizeA[i] !== sizeB[i]) {
            return dir === "asc" ? sizeA[i] > sizeB[i] : sizeA[i] < sizeB[i];
        }
    }
    return false;
}

// Функция для сравнения энергетического класса
function compareEnergyClass(a, b, dir) {
    const rankA = energyClassRank(a);
    const rankB = energyClassRank(b);
    return dir === "asc" ? rankA > rankB : rankA < rankB;
}

// Функция для определения ранга энергетического класса
function energyClassRank(energyClass) {
    const base = energyClass.replace(/\+/g, '');
    const pluses = (energyClass.match(/\+/g) || []).length;
    return `${base}${pluses}`; // Конкатенируем базу и количество плюсов
}

// Функция для сравнения чисел
function compareNumbers(a, b, dir) {
    const numA = parseFloat(a);
    const numB = parseFloat(b);
    return dir === "asc" ? numA > numB : numA < numB;
}

// Функция для сравнения строк
function compareStrings(a, b, dir) {
    return dir === "asc" ? a.toLowerCase() > b.toLowerCase() : a.toLowerCase() < b.toLowerCase();
}

// Функция поиска в таблице
function searchTable() {
    const input = document.getElementById("searchInput");
    const filter = input.value.toLowerCase();
    const table = document.getElementById("appliancesTable");
    const tr = table.getElementsByTagName("tr");

    for (let i = 1; i < tr.length; i++) {
        let td = tr[i].getElementsByTagName("td");
        let match = false;
        for (let j = 0; j < td.length; j++) {
            if (td[j]) {
                let txtValue = td[j].textContent || td[j].innerText;
                if (txtValue.toLowerCase().indexOf(filter) > -1) {
                    match = true;
                    break;
                }
            }
        }
        tr[i].style.display = match ? "" : "none";
    }
}
