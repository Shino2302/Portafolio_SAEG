//Remember ever use the Strict Mode
'use strict';
//let MiPrimeraFuncionFlecha = () => {
//    let nombre = document.forms["FormularioBasico"]["fNombre"].value;
//   let edad = document.forms["FormularioBasico"]["fEdad"].value;
//    return document.write(`
//            <h1>
//            Tú nombre es ${nombre} y tú edad es de ${edad} años
//            </h1>`);
//};
//Función hecha para crear varias secciones en el mismo div, cambiando todo el contenido
const seccionModificable = document.querySelector('.SeccionModificada')
//Variable para hacer cambios en el DOM
let depuracionDivs = () => {
    const infoDevElement = document.querySelector('.Info-Dev'); 
    const tecnologiasElement = document.querySelector('.Tecnologias');
    const proyectosElement = document.querySelector('.Proyectos');
    if (tecnologiasElement) {
        seccionModificable.removeChild(tecnologiasElement);
    } else if(infoDevElement) {
        seccionModificable.removeChild(infoDevElement);
    } else if (proyectosElement) {
        seccionModificable.removeChild(proyectosElement);
    }
    return true;
}
let crearPaginaAcercaDeMi = () =>{
    depuracionDivs();
    const div = document.createElement("div");
    div.classList.add("Info-Dev");
    div.innerHTML = 
        `<h1 class="Dev-Name">Sigfrido Alejandro Encinas Guerrero</h1>
         <br/>
         <h3 class="InformacionBasica">Edad: 21 años</h3>
         <h3 class="InformacionBasica">Correo: encinas.sigfrido.cbtis37@gmail.com</h3>
         <br/>
         `;
    seccionModificable.append(div);
    return true;
};

let crearPaginaTecnologias = () =>{
    depuracionDivs();
    const div = document.createElement("div");
    div.classList.add("Tecnologias");
    div.innerHTML = 
        `<h1 class="Dev-Name">Sigfrido Alejandro Encinas Guerrero</h1>
         <br/>
         <h3 class="InformacionBasica">Edad: 21 años</h3>
         <h3 class="InformacionBasica">Correo: encinas.sigfrido.cbtis37@gmail.com</h3>
         <br/>
         `;
    seccionModificable.append(div);
    return true;
};

let crearPaginaProyectos = () =>{
    depuracionDivs();
    const div = document.createElement("div");
    div.classList.add("Proyectos");
    div.innerHTML = 
        `<h1 class="">Sigfrido Alejandro Encinas Guerrero</h1>
         <br/>
         <h3 class="InformacionBasica">Edad: 21 años</h3>
         <h3 class="InformacionBasica">Correo: encinas.sigfrido.cbtis37@gmail.com</h3>
         <br/>
         `;
    seccionModificable.append(div);
    return true;
};