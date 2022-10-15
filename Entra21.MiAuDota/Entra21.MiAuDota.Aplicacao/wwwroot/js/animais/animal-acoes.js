$('table').on('click', '.animal-obterPorId', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    animalObterPorId(element);
});

$('table').on('click', '.animal-modalEditar', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;

    editarPreencherModal(element);
});

let editarPreencherModal = (botaoEditar) => {
    let id = botaoEditar.getAttribute('data-id');
    let statusResponse = 0;

    fetch(`/protetores/animal/obterPorId?id=${id}`)
        .then((response) => {
            statusResponse = response.status;

            return response.json();
        })
        .then((data) => {
            if (statusResponse === 200) {
                let modal = new bootstrap.Modal(document.getElementById('editarModal'), {});

                document.getElementById('editarModalLabel').innerText = `Editar animal: ${data.nome}`
                document.getElementById('editarModalId').value = data.id;
                document.getElementById('editarModalRaca').value = data.raca;
                document.getElementById('editarModalEspecie').value = data.especie;
                document.getElementById('editarModalSobre').value = data.sobre;
                document.getElementById('editarModalVacinas').value = data.vacinas;
                document.getElementById('editarModalAlergias').value = data.alergias;
                document.getElementById('editarModalOutrasInformacoes').value = data.outrasInformacoesMedicas;
                document.getElementById('editarModalFoto').value = data.foto;
                document.getElementById('editarModalFotoCampoImg').src = "/Uploads/Animais/" + data.foto;

                document.getElementById('editarModalIdade').value = data.idade;
                document.getElementById('editarModalPeso').value = data.peso;
                document.getElementById('editarModalAltura').value = data.altura;
                document.getElementById('editarModalCastrado').value = data.cadastro;
                document.getElementById('editarModalDataAdocao').value = data.dataAdocao;
                document.getElementById('editarModalGenero').value = data.genero;
                document.getElementById('editarModalStatus').value = data.status;
                document.getElementById('editarModalPorte').value = data.porte;
                document.getElementById('editarModalUsuarioId').value = data.usuarioId;

                modal.show();
            }
        })
        .catch((error) => console.log(error));
};

let animalObterPorId = (element) => {
    let id = botaoEditar.getAttribute('data-id');
    let statusResponse = 0;

    fetch(`/protetores/animal/obterPorId?id=${id}`)
        .then((response) => {
            statusResponse = response.status;

            return response.json();
        })
        .then((data) => {
            if (statusResponse === 200) {
                let modal = new bootstrap.Modal(document.getElementById('VisualizarModal'), {});

                document.getElementById('editarModalLabel').innerText = `Editar animal: ${data.nome}`
                document.getElementById('editarModalId').value = data.id;
                document.getElementById('editarModalRaca').value = data.raca;
                document.getElementById('editarModalEspecie').value = data.especie;
                document.getElementById('editarModalSobre').value = data.sobre;
                document.getElementById('editarModalVacinas').value = data.vacinas;
                document.getElementById('editarModalAlergias').value = data.alergias;
                document.getElementById('editarModalOutrasInformacaoes').value = data.outras_infos_medicas;
                document.getElementById('editarModalFoto').value = data.caminho_arquivo;
                document.getElementById('editarModalIdade').value = data.idade;
                document.getElementById('editarModalPeso').value = data.peso;
                document.getElementById('editarModalAltura').value = data.altura;
                document.getElementById('editarModalCastrado').value = data.cadastro;
                document.getElementById('editarModalDataAdocao').value = data.data_adocao;
                document.getElementById('editarModalDatagenero').value = data.genero;
                document.getElementById('editarModalDataStatus').value = data.status;
                document.getElementById('editarModalDataPorte').value = data.porte;
                document.getElementById('editarModalDataUsuarioId').value = data.usuario_id;

                modal.show();
            }
        })
        .catch((error) => console.log(error));
};