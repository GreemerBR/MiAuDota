let animalBotaoSalvarModalEditar = () => {
    let id = parseInt(document.getElementById('editarModalId').value);
    let nome = document.getElementById('editarModalNome').value;
    let raca = document.getElementById('editarModalRaca').value;
    let especie = document.getElementById('editarModalEspecie').value;
    let sobre = document.getElementById('editarModalSobre').value;
    let foto = document.getElementById('Arquivo').files[0];
    let idade = document.getElementById('editarModalIdade').value;
    let peso = document.getElementById('editarModalPeso').value;
    let altura = document.getElementById('editarModalAltura').value;
    let cadastro = document.querySelector('input[name="editarModalCastrado"]:checked').value;
    let dataAdocao = document.getElementById('editarModalDataAdocao').value;
    let genero = document.getElementById('editarModalGenero').value;
    let status = document.getElementById('editarModalStatus').value;
    let usuarioId = document.getElementById('editarModalUsuarioId').value;

    let formData = new FormData();
    formData.append('id', id);
    formData.append('nome', nome);
    formData.append('raca', raca);
    formData.append('especie', especie);
    formData.append('sobre', sobre);
    formData.append('idade', idade);
    formData.append('arquivo', foto);
    formData.append('peso', peso);
    formData.append('altura', altura);
    formData.append('castrado', cadastro);
    formData.append('dataAdocao', dataAdocao);
    formData.append('genero', genero);
    formData.append('status', status);
    formData.append('usuarioId', usuarioId);

    fetch('/protetores/animal/editarAnimal', {
        method: 'POST',
        body: formData
    })
        .then((response) => {
            statusResponse = response.status;

            return response;
        })
        .then((response) => {
            if (response.status === 200) {

                let modal = bootstrap.Modal.getInstance(document.getElementById('editarModal'), {});
                modal.hide();

                $('#tabela-animais').DataTable().ajax.reload();
                return;
            }
        })
        .catch((error) => console.log(error));
};

document.getElementById('editarModalSalvar').addEventListener('click', () => {
    animalBotaoSalvarModalEditar();
});