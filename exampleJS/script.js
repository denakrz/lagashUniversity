function borrarRepetidas(palabra) {
    var palabraNueva = "";
    var palabraToLowerCase = palabra.toLowerCase();
    var repetido = false;
    for (var i = 0; i < palabraToLowerCase.length; i++) {
        repetido = false;
        for (var j = 0; j < palabraNueva.length; j++) {
            if(palabraToLowerCase[i] == palabraNueva[j]) {
                repetido = true;
            }
        }
        if(repetido == false) {
            palabraNueva += palabraToLowerCase[i];
        }
      }
      
      console.log(palabraNueva);
}