let documento = document.getElementsByClassName('contenidoFilms')[0];
let html = document.getElementsByTagName('html')[0];
html.style.backgroundColor = '#141414';
documento.style.backgroundColor = '#141414';
let principal = document.getElementsByTagName('main')[0];
principal.classList.remove('pb-3');

let peliculasGenero = [];
console.log(arrayOfArrays)

function EncontrarVideo(imagen) {

    for (let i = 0; i < arrayOfArrays.length; i++) {
        if (arrayOfArrays[i].Image == imagen.src) {
            return arrayOfArrays[i];
        }
        else {
            return imagen;
        }
    }
}

//ICONO DE ESCUCHAR

let cajaSonido = document.getElementsByClassName('sonido')[0];
let myVideo = document.getElementsByClassName('miVideo')[0];
let microfono = document.getElementsByTagName('i')[1];
myVideo.muted = false;



cajaSonido.addEventListener('mouseover', function () {
    microfono.style.color = 'white';
})
cajaSonido.addEventListener('mouseout', function () {
    microfono.style.color = 'darkslategray';
})


cajaSonido.addEventListener('click', function () {
    if (myVideo.muted == true) {
        myVideo.muted = false;
        cajaSonido.innerHTML = '<i class="fas fa-microphone-alt"></i>';
    }
    else {
        myVideo.muted = true;
        cajaSonido.innerHTML = '<i class="fas fa-microphone-alt-slash"></i>';
    }
})


//EFECTO CONTROLES

let controles = document.getElementsByClassName('controles');

for (let i = 0; i < controles.length; i++) {

    controles[i].addEventListener('mouseover', function () {
        this.style.backgroundColor = 'white';
        this.style.color = 'black';
        this.style.opacity = '0.5'
    })
    controles[i].addEventListener('mouseout', function () {
        this.style.backgroundColor = null;
        this.style.color = 'white';
    })
}

//HEADER DE COLOR EN SCROLL


//CAMBIAR IMAGENES POR TRAILER

let imagenes = document.getElementsByClassName('imagenPeli');

for (let i = 0; i < imagenes.length; i++) {
    imagenes[i].addEventListener('mouseover', function () {

        console.log(EncontrarVideo(imagenes[i]));

    })
}