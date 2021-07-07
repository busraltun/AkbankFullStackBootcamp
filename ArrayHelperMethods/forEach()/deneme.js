const numbers = [2, 4, 6, 8]

numbers.forEach ((number, index) => {
    numbers[index] = number * 2;

});

document.write(numbers); 