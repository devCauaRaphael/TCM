/*metodo do menu hamburguer*/
const menuToggle = document.getElementById("menuToggle");
const menu = document.getElementById("menu");
menuToggle.addEventListener('click',()=>{
    menu.classList.toggle('open');
}); 
/*metodo troca de fundo*/
const toggleThemeButton = document.getElementById('temaToggle');

toggleThemeButton.addEventListener('click', () => {
  document.body.classList.toggle('temaClaro');
});




/*metodo do carrossel*/
/*slide 1*/
const carrossel01 = document.querySelector(".carrossel01");
const slides01 = carrossel01.querySelector(".slides01");
const prev01 = carrossel01.querySelector(".prev01");
const next01 = carrossel01.querySelector(".next01");

let index01 = 0;
const totalSlides01 = slides01.children.length;

function moveToSlide01(index) {
    // Impede rotação fora dos limites
    if (index < 0) index = totalSlides01 - 1;
    if (index >= totalSlides01) index = 0;

    // Atualiza a posição dos slides
    slides01.style.transform = `translateX(-${index * 100}%)`;
    index01 = index;
}

prev01.addEventListener("click", () => {
    moveToSlide01(index01 - 1);
});

next01.addEventListener("click", () => {
    moveToSlide01(index01 + 1);
});

// Inicializa o carrossel
moveToSlide01(index01);




document.addEventListener("DOMContentLoaded", function() {
    // código do carrossel02 aqui
  });
// Carrossel 2
const carrossel02 = document.querySelector(".carrossel02");
const slides02 = carrossel02.querySelector(".slides02");
const prev02 = carrossel02.querySelector(".prev02");
const next02 = carrossel02.querySelector(".next02");

let index02 = 0;
const totalSlides02 = slides02.children.length;


function moveToSlide02(index) {
    // Impede rotação fora dos limites
    if (index < 0) index = totalSlides02 - 1;
    if (index >= totalSlides02) index = 0;

 
    slides02.style.transform = `translateX(-${index * 100}%)`;
    index02 = index;
}

prev02.addEventListener("click", () => {
    moveToSlide02(index02 - 1);
});

next02.addEventListener("click", () => {
    moveToSlide02(index02 + 1);
});

moveToSlide02(index02);