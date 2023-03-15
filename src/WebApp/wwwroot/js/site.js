// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
(() => {
    'use strict';
    const forms = document.querySelectorAll('.needs-validation');
    Array.prototype.slice.call(forms).forEach((form) => {
        form.addEventListener('submit', (event) => {
            if (!form.checkValidity()) {
                event.preventDefault();
                event.stopPropagation();
            }
            form.classList.add('was-validated');
        }, false);
    });
})();


function validaUsu() {

    let Login = $('#login').val();
    let Senha = $('#senha').val();

    var enViaPost = {
        Nome: null,
        SobreNome: null,
        Email: null,
        Idade: null,
        Login: Login,
        Senha: Senha

    }

    $.ajax({
        type: 'POST',
        url: '/Home/ValidaLogin',
        data: JSON.stringify(enViaPost),
        success: function (data) { alert('data: ' + data); },
        contentType: "application/json",
        dataType: 'json',
        success: function (result) {
            alert("Usuário sendo redirecionado!")
            location.href = "/Usuario/";
        },
        error: function (err) {
            alert("Dados inválidos !")
        }
    });
}


function enviarForm() {

    debugger;


    let Nome = $('#nome').val();
    let SobreNome = $('#sobreNome').val();
    let Email = $('#email').val();
    let idade = $('#idade').val();
    let Login = $('#user').val();
    let Senha = $('#pass').val();


    var enViaPost = {
        Nome: Nome,
        SobreNome: SobreNome,
        Email: Email,
        Idade: idade,
        Login: Login,
        Senha: Senha

    }


    $.ajax({
        type: 'POST',
        url: '/Home/InsereUsuario',
        data: JSON.stringify(enViaPost),
        success: function (data) { alert('data: ' + data); },
        contentType: "application/json",
        dataType: 'json',
        success: function (result) {
            // when call is sucessfull
        },
        error: function (err) {
            // check the err for error details
        }
    });
    
}
