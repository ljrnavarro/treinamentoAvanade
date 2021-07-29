document.addEventListener("DOMContentLoaded", function(){
    const meuCabecalho = document.querySelector('h1');
    meuCabecalho.textContent = 'Ola mundo!';
    
    let minhaImagem = document.querySelector('img');

        minhaImagem.onclick = function() {
            let meuSrc = minhaImagem.getAttribute('src');
            if(meuSrc === 'images/firefox-icon.png') {
            minhaImagem.setAttribute ('src','images/firefox.jpg');
            } else {
            minhaImagem.setAttribute ('src','images/firefox-icon.png');
            }
        }

 });


 //document.querySelector('html').onclick = function() {
//   alert('Ai! Pare de me cutucar!');
//}

