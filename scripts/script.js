/*metodo do menu hamburguer*/
const menuToggle = document.getElementById("menuToggle");
const menu = document.getElementById("menu");
menuToggle.addEventListener('click',()=>{
    menu.classList.toggle('open');
}); 
