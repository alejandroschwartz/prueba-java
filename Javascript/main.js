let nombre = "ale";
let split = nombre.split('');

// Estructura de datos LindedList (clave : valor)
const LETRAS = {
  a : 2,
  b : 22, 
  c : 222, 
  d : 3, 
  e : 33,
  f : 333, 
  g : 4,
  h : 44,
  i : 444,
  j : 5,
  k : 55,
  l : 555,
  m : 6,
  n : 66,
  o : 666,
  p : 7,
  q : 77,
  r : 777,
  s : 7777,
  t : 8,
  u : 88,
  v : 888,
  w : 9,
  x : 99,
  y : 999,
  z : 9999,
  ' ' : `\n`
}

let nuevoArray = [];

split.map(item => {
  nuevoArray.push( LETRAS[item] );
})

console.log(nuevoArray.join(' '));



// ----- Resolución usando un Switch ----- 
// let nombre = "ale";
// console.log(nombre);

// let split = nombre.split('');
// console.log(split);

// let nuevoArray = []

// split.map(item => {
//   switch(item) {
//     case item = 'a': 
//       nuevoArray.push(1); 
//       break;
//     case item = 'l': 
//       nuevoArray.push(555); 
//       break;
//     case item = 'e': 
//       nuevoArray.push(22); 
//       break;
//   }
// })

// console.log(nuevoArray);

// const respuesta = nuevoArray.join(' ')
// console.log(respuesta);
