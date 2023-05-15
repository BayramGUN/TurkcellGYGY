// JSON: JavaScript Object Notation

var employee = {
    name: 'türkay',
    surname: 'ürkmez',
    age: 43
}


var employees = [
    {
        name: 'türkay',
        surname: 'ürkmez',
        age: 43
    },
    {
        name: 'brad',
        surname: 'pitt',
        age: 59
    },
    {
        name: 'angelina',
        surname: 'jolie',
        age: 52
    }
]

function showEmployees() {
    var table = document.createElement('table');

    document.getElementById('employeePlaceHolder').innerHTML = '';
    var title = document.createElement('tr');
    var titleName = document.createElement('td');
    var titleLastName = document.createElement('td');
    var titleAge = document.createElement('td');
    title.appendChild(titleName);
    title.appendChild(titleLastName);
    title.appendChild(titleAge);
    table.append(title);
    employees.forEach((employee) => {
        console.table(employee);
        var row = getEmployeeOnRow(employee);
        table.append(row);    
    });
    document.getElementById('employeePlaceHolder').append(table);
}

function getEmployeeOnRow(employee) {
    var row = document.createElement('tr');
    var cellName = document.createElement('td');
    var cellLastName = document.createElement('td');
    var cellAge = document.createElement('td');

    cellName.innerText = employee.name;
    cellLastName.innerText = employee.surname;
    cellAge.innerText = employee.age;

    row.appendChild(cellName);
    row.appendChild(cellLastName);
    row.appendChild(cellAge);

    return row;
}