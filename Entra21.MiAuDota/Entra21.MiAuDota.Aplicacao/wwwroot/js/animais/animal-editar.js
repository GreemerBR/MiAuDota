let animalBotaoSalvarModalEditar = () => {
    let id = parseInt(document.getElementById('editarModalId').value);
    let raca = document.getElementById('editarModalRaca').value;
    let especie = document.getElementById('editarModalEspecie').value;
    let sobre = document.getElementById('editarModalSobre').value;
    let vacinas = document.getElementById('editarModalVacinas').value;
    let alergias = document.getElementById('editarModalAlergias').value;
    let outras_infos_medicas = document.getElementById('editarModalOutrasInformacoes').value;
    let caminho_arquivo = document.getElementById('editarModalFoto').value;
    let idade = document.getElementById('editarModalIdade').value;
    let peso = document.getElementById('editarModalPeso').value;
    let altura = document.getElementById('editarModalAltura').value;
    let cadastro = document.getElementById('editarModalCastrado').value;
    let data_adocao = document.getElementById('editarModalDataAdocao').value;
    let genero = document.getElementById('editarModalGenero').value;
    let status = document.getElementById('editarModalStatus').value;
    let porte = document.getElementById('editarModalPorte').value;
    let usuario_id = document.getElementById('editarModalUsuarioId').value;

    let formData = new FormData();
    formData.append('id', id);
    formData.append('raca', raca);
    formData.append('especie', especie);
    formData.append('sobre', sobre);
    formData.append('vacinas', vacinas);
    formData.append('alergias', alergias);
    formData.append('outrasInformacoes', outras_infos_medicas);
    formData.append('idade', idade);
    formData.append('foto', caminho_arquivo);
    formData.append('peso', peso);
    formData.append('altura', altura);
    formData.append('castrado', cadastro);
    formData.append('dataAdocao', data_adocao);
    formData.append('genero', genero);
    formData.append('status', status);
    formData.append('porte', porte);
    formData.append('usuarioId', usuario_id);

    fetch('/protetores/animal/editar', {
        method: 'POST',
        
        body: formData
    })
        .then((response) => {
            if (response.status === 200) {
                toastr.success('Animal alterado com sucesso');

                let modal = bootstrap.Modal.getInstance(document.getElementById('EditarModal'), {});
                modal.hide();

                $('#tabela-animais').DataTable().ajax.reload();
                return;
            }

            toastr.error('Não foi possível alterar o animal');
        })
        .catch((error) => console.err(error));
};

document.getElementById('editarModalSalvar').addEventListener('click', () => {
    animalBotaoSalvarModalEditar();
});