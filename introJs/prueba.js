
var test = 'LagashU'; 

function imprimir () {
    var test = 'Max' ;
    if (true){
        var test = 'Max';
    }

    console.log(test);
}

imprimir(); // imprime lagash

////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////


function imprimir() {
    let test = 'Max'; // let muere en el bloque, si termina if, no existe más
}

imprimir(); // imprime max

/////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////

var test = 'LagashU';

function imprimir() {
    let test = 'Max';
}

imprimir (); // imprime lagashu

/////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////

// ALERT //  está definido en el navegador.

// debugger; //  frena el código en el browser, es un "break point", se pueden ver en los watch de consola.

/////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////

function sumar (valor1, valor2){
    return parseInt(valor1) + parseInt(valor2);
}

var v1 = prompt('Ingrese valor 1');

var v2 = prompt('Ingrese valor 2');

alert(sumar(v1,v2));