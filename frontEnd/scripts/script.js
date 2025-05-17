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
const totalSlides01 = slides01.children.length - 1;

function moveToSlide01(index) {
    // Impede rotação fora dos limites
    if (index < 0) index = totalSlides01;
    if (index > totalSlides01) index = 0;

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




/*slide2 */
const carrossel02 = document.querySelector(".carrossel02");
const slides02 = carrossel02.querySelector(".slides02");
const prev02 = carrossel02.querySelector(".prev02");
const next02 = carrossel02.querySelector(".next02");

let index02 = 0;
const totalSlides02 = slides02.children.length - 1;


function moveToSlide02(index) {
    // Impede rotação fora dos limites
    if (index < 0) index = totalSlides02;
    if (index > totalSlides02) index = 0;

 
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

/*slide 3*/
const carrossel03 = document.querySelector(".carrossel03");
const slides03 = carrossel03.querySelector(".slides03");
const prev03 = carrossel03.querySelector(".prev03");
const next03 = carrossel03.querySelector(".next03");

let index03 = 0;
const totalSlides03 = slides03.children.length - 1;


function moveToSlide03(index) {
    // Impede rotação fora dos limites
    if (index < 0) index = totalSlides03;
    if (index > totalSlides03) index = 0;

 
    slides03.style.transform = `translateX(-${index * 100}%)`;
    index03 = index;
}
prev03.addEventListener("click", () => {
    moveToSlide03(index03 - 1);
});

next03.addEventListener("click", () => {
    moveToSlide03(index03 + 1);
});
moveToSlide03(index03)


//carrossel divulgação
const carrosselDivulgacao = document.querySelector('.carrosselDivulgacao');
const slidesDivulgacao = carrosselDivulgacao.querySelector('.slidesDivulgacao');
const imagens = slidesDivulgacao.querySelectorAll('.slideDivulgacao');


let indice = 0;
let tempo = 5000; // 5 segundos

// Declara a função alterarImagem, que será usada para alterar a imagem ativa
function alterarImagem() {
  // Define a opacidade da imagem atual como 0, tornando-a invisível
  imagens[indice].style.opacity = 0;

  // Incrementa a variável indice em 1, preparando-a para a próxima imagem
  indice++;

  // Verifica se o indice é maior ou igual ao número de imagens
  if (indice >= imagens.length) {
    // Se sim, redefine o indice para 0, preparando-o para a primeira imagem novamente
    indice = 0;
  }

  // Define a opacidade da próxima imagem como 1, tornando-a visível
  imagens[indice].style.opacity = 1;
}

// Chama a função alterarImagem a cada 5 segundos
setInterval(alterarImagem, tempo);
