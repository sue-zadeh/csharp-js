
let s = "hello";
console.log(s.length);
console.log(s.substring(1, 3));  // "el"
console.log(s.includes("he"));   // true

// WELCOME my code for discount

// Using for...of loop:

for (let num of numbers) {
  if (num % 2 === 0) {
    console.log(num);
  }
}
// ➤ Using map (⚠️ not preferred here):

numbers.map(num => {
  if (num % 2 === 0) {
    console.log(num);
  }
});
// ⚠️ map() is usually used when you want to transform data and return a new array — not just print.

// Using a regular for loop
for (let i = 0; i < numbers.length; i++) {
  if (numbers[i] % 2 === 0) {
    console.log(numbers[i]);
  }
}

// Using filter to get even numbers
const evenNumbers = numbers.filter(num => num % 2 === 0);
console.log(evenNumbers);

//=======================
const numbers = [3, 6, 7, 2, 9, 10];

numbers.forEach(num => {
  if (num % 2 === 0) {
    console.log(num);
  }
});
//or:
// const numbers = [3, 6, 7, 2, 9, 10];

numbers.forEach(function(num) {
  if (num % 2 === 0) {
    console.log(num);
  }
});
