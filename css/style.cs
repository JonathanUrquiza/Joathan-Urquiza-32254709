@charset "UTF-8";
@import url("https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;900&display=swap");
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  list-style: none;
  font-family: "Roboto", sans-serif;
}

a {
  text-decoration: none;
}

i {
  color: white;
}

.tarjeta__boton {
  background-color: whitesmoke;
  border-top: 2px solid black;
  border-right: 2px solid black;
  border-radius: 15px;
  display: flex;
  justify-content: center;
}
.tarjeta__boton:active {
  border: 3px solid black;
}

.contenedor1 {
  height: 30%;
}
.contenedor1__marca {
  height: 100%;
}
.contenedor1__pub {
  height: 60px;
  width: 50px;
}

nav {
  background-color: orangered;
  margin-bottom: 5px;
}

.logo {
  height: 20px;
}

main {
  background-image: url(../img/logo/fondodetarjeta.jpg);
  background-repeat: no-repeat;
  background-size: cover;
  background-position: center;
  background-attachment: fixed;
  height: 100%;
}

section {
  background-color: rgba(255, 255, 255, 0.699);
}

.lineas li {
  border: 3px solid rgb(0, 0, 0);
  background-color: aqua;
  color: blue;
  padding: 1px;
  margin-bottom: 2px;
  margin-left: 10px;
  width: 50px;
}

.cuerpo {
  background-color: rgba(255, 255, 255, 0.699);
}
.cuerpo__presentación {
  margin: 2px;
  padding: 2px;
  gap: 2px;
}
.cuerpo__banner {
  border: 5px solid rgb(252, 4, 4);
  height: 100%;
  width: 100%;
  padding: 5px;
}

.tarjeta__promo {
  border: 1px solid black;
  border-radius: 25px;
  width: 100%;
}
@media (max-width: 899px) {
  .tarjeta__promo {
    font-size: 1.5rem;
  }
}
.tarjeta__promo:hover {
  border: 3px solid rgb(0, 0, 0);
}

@media (min-width: 900px) {
  #whatsapp {
    display: none;
  }
}
@media (max-width: 899px) {
  #whatsapp {
    height: 50px;
    position: fixed;
    left: 20px;
    bottom: 40px;
    z-index: 1;
  }
}

.tecnicos {
  background-color: rgba(255, 255, 255, 0.699);
  padding: 5px;
}
.tecnicos__operario {
  width: 184px;
  height: 100%;
  padding: 5px;
  margin: 2px;
  border: 3px solid rgb(0, 0, 0);
  border-radius: 15px;
  background-color: rgba(255, 68, 0, 0.61);
}
.tecnicos__foto {
  width: 100px;
  height: 100px;
}

.publicidad {
  border: 3px solid rgb(0, 0, 0);
  background-color: rgba(255, 255, 255, 0.699);
}
.publicidad__contenido {
  padding: 1px;
}

.mensaje {
  border: 2px solid black;
  border-radius: 20px;
  background-color: rgb(206, 191, 186);
}

footer {
  border: 3px solid rgb(0, 0, 0);
  width: 100%;
  align-items: center;
}

@media (min-width: 900px) {
  footer {
    border: 3px solid rgb(0, 0, 0);
  }
}

/*# sourceMappingURL=style.cs.map */
