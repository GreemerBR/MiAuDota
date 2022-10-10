$('#tabela-protetores').DataTable({
    language: {
        url: 'https://raw.githubusercontent.com/DataTables/Plugins/master/i18n/pt-BR.json'
    },
    ajax: {
        url: '/protetor/obterTodos',
        dataSrc: ''
    },
    processing: true,
    columns: [
        { data: 'nome' },
        {
            data: null,
            render: function (data, type, protetor) {
                let cor = '';
                let status = '';
                if (protetor.isActive === false) {
                    status = "Conta Inativa";
                    cor = "danger";
                } else {
                    status = "Ativa";
                    cor = "success";

                }
                return `<span class="badge bg-${cor}">${status}</span>`;
            },
        },
        {
            data: null,
            width: '20%',
            render: function (data, type, protetor) {
                if (protetor.isActive === false) {
                    return `<button class="btn btn-primary protetor-alterarStatus" data-id="${protetor.id}">Ativar</button>`;
                }

                return "";
            }
        }
    ],
});