function solve(arr) {

    let text = arr.join(",");
    let myArr = text.split(/\W+/);

    for (i = 0; i < myArr.length; i++) {
        console.log(myArr[i]);
    }
}

solve(['PHP, java, HTML, GAG and bob and GIG']);