function redirecionar(){
    const escolha = confirm("Você quer ir para a página de cadastro? Se clicar em 'Cancelar', será redirecionado para a página de login.")
    if(escolha){
        window.location.href = "cadastro.html";
    }
    else{
        window.location.href = "login.html";
    }
}
document.getElementById("botao-login").addEventListener("click", redirecionar);


function cadastrese(){
window.location.href = "cadastro.html";
}
document.getElementById("cadastrese-agora").addEventListener("click", cadastrese);
