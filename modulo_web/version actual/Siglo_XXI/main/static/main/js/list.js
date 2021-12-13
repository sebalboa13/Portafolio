$(function () {
    $('#data').DataTable({
        responsive: true,
        autoWidth: false,
        destroy: true,
        deferRender: true,
        ajax: {
            url: window.location.pathname,
            type: 'POST',
            data: {
                'action': 'searchdata'
            },
            dataSrc: ""
        },
        columns: [
            {"data": "id_ingrediente"},
            {"data": "ingrediente"},
            {"data": "marca"},
            {"data": "cantidad"},
           
        ],
        columnDefs: [
           
            {
                targets: [-4],
                class: 'text-center',
                orderable: false,
                render: function (data, type, row) {
                    if(row.cantidad > 0){
                        return '<span class="badge badge-success">'+data+'</span>'
                    }
                    return '<span class="badge badge-danger">'+data+'</span>'
                }
            },
           
            
        ],
        initComplete: function (settings, json) {

        }
    });
});
