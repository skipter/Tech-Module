function solve(arr) {

    let text = arr.join(",");
    let myArr = text.split(/\W+/);
    let upperCase = myArr.filter(isUpperCase);
    console.log(upperCase.join(", "));


    function isUpperCase(str) {
        return str === str.toUpperCase();
    }
}

solve(['We start by HTML, CSS, JavaScript, JSON and REST.' +
'Later we touch some PHP, MySQL and SQL.' +
'Later we play with C#, EF, SQL Server and ASP.NET MVC.' +
'Finally, we touch some Java, Hibernate and Spring.MVC.']);