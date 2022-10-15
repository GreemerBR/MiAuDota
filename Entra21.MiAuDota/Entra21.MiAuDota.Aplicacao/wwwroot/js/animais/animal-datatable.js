$('#tabela-animais').DataTable({
    language: {
        url: 'https://raw.githubusercontent.com/DataTables/Plugins/master/i18n/pt-BR.json'
    },
    ajax: {
        url: '/animal/obterTodos',
        dataSrc: ''
    },
    processing: true,
    columns: [
        { data: 'nome' },
        { data: 'foto' },
        {
            data: null,
            render: function (data, type, animal) {
                let cor = '';
                let status = '';
                if (animal.status === 0) {
                    status = "Apto para adoção";
                    cor = "warning";
                } else if (animal.status === 1) {
                    status = "Em tratamento";
                    cor = "danger";

                } else {
                    status = "Adotado";
                    cor = "success";

                }
                return `<h4><span class="badge bg-${cor}">${status}</span></h4>`;
            },
        },
        {
            data: null,
            width: '20%',
            render: function (data, type, animal) {
                if (animal.status === 0 || animal.status === 1) {
                    return `<button class="btn btn-info animal-modalEditar" data-id="${animal.id}">Editar</button>`;
                }

                return `<button class="btn btn-primary animal-obterPorId" data-id="${animal.id}">Ver detalhes</button>`;

                return "";
            }
        }
    ],
});