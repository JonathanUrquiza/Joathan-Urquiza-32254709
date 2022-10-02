
/*
let miNombre;

miNombre = "Jona";

console.log(miNombre);//Jona

console.log("miNombre");//miNombre

minombre = "Maria";

console.log(minombre); //Maria

*/
function procesar(e){
    e.preventDefault();
    let user;
    let date;
    let ages;
    let td;


    user = document.getElementById("inputNombre").value;
    date = parseInt(document.getElementById("inputfechaNac").value);



    td = new Date().getFullYear();
    ages = td - date;

    console.log("Hola " + user + " su edad es " + ages);
}
document.getElementById("elform").onsubmit = procesar;



