// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let footer = document.getElementsByTagName('footer')[0];
footer.classList.add('collapse');
//let peliculasGenero = [];

//let fichapeli = document.getElementsByClassName('fichapeli');
//let mediaContainer = document.getElementsByClassName('cFYCF');


//for (var i = 0; i < mediaContainer.length; i++) {

       
//    mediaContainer[i].addEventListener('mouseover', function () {

//        let videoUrl = this.getAttribute('data-url-video');
//        let image = this.querySelector('.imagen');
//        if (image != null) {
//            this.removeChild(image);
     
//            let video = "<iframe width='"+560+"' height='"+315+"' src =" + videoUrl + " frameborder='" + 0 + "' allow='accelerometer; encrypted-media; gyroscope; picture-in-picture'" + "allowfullscreen></iframe>";
//            this.innerHTML = video + this.innerHTML;
//        }
//    });
//    mediaContainer[i].addEventListener('mouseout', function () {

//        let imagenUrl = this.getAttribute('data-url-img');
//        let imagenTitle = this.getAttribute('title');
//        let video = this.querySelector('iframe');
//        if (video!= null) {
//            this.removeChild(video);
//            let imagen = " <img class="+"imagen"+" src=" + imagenUrl + " title=" + imagenTitle +">"
//            this.innerHTML = imagen + this.innerHTML;
//        }
        
//    });

//}


//let mediaContainerS = document.getElementsByClassName('cFYCFsearch');

//for (var i = 0; i < mediaContainerS.length; i++) {

//    mediaContainerS[i].addEventListener('click', function () {


//    });

//}



////ICONO DE ESCUCHAR

//let cajaSonido = document.getElementsByClassName('sonido')[0];
//let myVideo = document.getElementsByClassName('miVideo')[0];
//let microfono = document.getElementsByTagName('i')[1];
//myVideo.muted = false;



//    cajaSonido.addEventListener('mouseover', function () {
//        microfono.style.color = 'white';
//    })
//    cajaSonido.addEventListener('mouseout', function () {
//        microfono.style.color = 'darkslategray';
//    })


//cajaSonido.addEventListener('click', function () {
//    if (myVideo.muted == true) {
//        myVideo.muted = false;
//        cajaSonido.innerHTML = '<i class="fas fa-microphone-alt"></i>';              
//    }
//    else {
//        myVideo.muted = true;       
//        cajaSonido.innerHTML = '<i class="fas fa-microphone-alt-slash"></i>';       
//    }
//})






//function mouseOut() {
    
//};
            //let video = document.creteElement('iframe');
            //video.src = videoUrl;
            //video.frameborder = 0;

        //let video = "<iframe  src =" + videoUrl + " frameborder=" + 0 + " allow=" + "accelerometer; autoplay; encrypted - media; gyroscope; picture -in -picture" + "allowfullscreen></iframe>";
        //let container = "<div class=" + "cFYCF" + " data-url-video=" + videoUrl + ">" + video + "</div>";
        //fichapeli[i].appendChild(container);

        //if (image) {
        //let videoYoutube = document.createElement("iframe");
        //videoYoutube.src = videoUrl[i];
        //videoYoutube.setAttribute('frameborder', 0);
       // mediaContainer[i].replaceChild(videoYoutube);

        //}

$(window).scroll(function () {
    if ($("#barraNav").offset().top>56) {
        $("#barraNav").addClass("bg-inverse");
    }
    else {
        $("#barraNav").removeClass("bg-inverse");
    }
})

