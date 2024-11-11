/*metodo do menu hamburguer*/
const menuToggle = document.getElementById("menuToggle");
const menu = document.getElementById("menu");
menuToggle.addEventListener('click',()=>{
    menu.classList.toggle('open');
}); 
/*metodo do carrossel*/
var correrSlide = 0;
const slides = document.querySelectorAll('.slide');
document.querySelector('.next').addEventListener('click', () => {
 NextSlide();
});
document.querySelector('.prev').addEventListener('click', () => {
    PrevSlide();
 });

 function NextSlide() {
    correrSlide = (correrSlide + 1) % slides.length;
    AlterarPosicaoSlide();
 }
 function PrevSlide() {
    correrSlide = (correrSlide - 1) % slides.length;
    AlterarPosicaoSlide();
 }
 function AlterarPosicaoSlide() {
     const slidesContainer = document.querySelector('.slides');
     slidesContainer.style.transform = `translateX(-${correrSlide * 100}%)`;
 }
 