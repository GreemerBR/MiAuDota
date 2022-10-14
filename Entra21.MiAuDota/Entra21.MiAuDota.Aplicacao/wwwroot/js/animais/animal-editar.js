let EditarPreencherModal = (botaoEditar) => {
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

let animalBotaoSalvarModalEditar = () => {
    let id = parseInt(document.getElementById('editarModalId'));
    let raca = document.getElementById('editarModalRaca').value;
    let especie = document.getElementById('editarModalEspecie').value;
    let sobre = document.getElementById('editarModalSobre').value;
    let vacinas = document.getElementById('editarModalVacinas').value;
    let alergias = document.getElementById('editarModalAlergias').value;
    let outras_infos_medicas  = document.getElementById('editarModalOutrasInformacaoes').value;
    let caminho_arquivo = document.getElementById('editarModalFoto').value;
    let idade = document.getElementById('editarModalIdade').value;
    let peso = document.getElementById('editarModalPeso').value;
    let altura = document.getElementById('editarModalAltura').value;
    let cadastro = document.getElementById('editarModalCastrado').value;
    let data_adocao = document.getElementById('editarModalDataAdocao').value;
    let genero = document.getElementById('editarModalDatagenero').value;
    let status = document.getElementById('editarModalDataStatus').value;
    let porte = document.getElementById('editarModalDataPorte').value;
    let usuario_id = document.getElementById('editarModalDataUsuarioId').value;

    fetch('/protetores/animal/editar', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            id: id,
            raca: raca,
            especie: especie,
            sobre: sobre,
            vacinas: vacinas,
            alergias: alergias,
            outras_infos_medicas: outras_infos_medicas,
            caminho_arquivo: caminho_arquivo,
            idade: idade,
            peso: peso,
            altura: altura,
            cadastro: cadastro,
            data_adocao: data_adocao,
            genero: genero,
            status: status,
            porte: porte,
            usuario_id: usuario_id
        })
    })
        .then((response) => {
            if (response.status === 200) {
                toastr.success('Animal alterado com sucesso');

                let modal = bootstrap.Modal.getInstance(document.getElementById('editarModal'), {});
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