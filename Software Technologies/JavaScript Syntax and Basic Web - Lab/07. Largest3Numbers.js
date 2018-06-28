function solve(numbers) {

    let sortedNumbers = numbers.sort((a, b) => (a - b));
    sortedNumbers.reverse();

    if (sortedNumbers.length <= 2) {
        console.log(sortedNumbers.shift());
        console.log(sortedNumbers.shift());
    } else {
        console.log(sortedNumbers.shift());
        console.log(sortedNumbers.shift());
        console.log(sortedNumbers.shift());
    }
}
solve(['10', '30', '15', '20', '50', '5']);