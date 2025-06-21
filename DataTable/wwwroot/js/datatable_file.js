$(document).ready(function () {
    GetStudent();
});

function GetStudent() {
    $.ajax({
        url: '/Home/GetStudentList',
        type: 'GET',
        dataType: 'json',
        success: OnSuccess
    });
}

function OnSuccess(response) {
    $('#dataTable').DataTable({
        bProcessing: true,
        bLengthChange: true,
        lengthMenu: [[5, 10, 25, -1], [5, 10, 25, "All"]],
        bFilter: true,
        bSort: true,
        bPaginate: true,
        destroy: true, 
        data: response,
        columns: [
            { data: 'id' },
            { data: 'studentName' },
            { data: 'studentGender' },
            { data: 'age' },
            { data: 'fatherName' },
            { data: 'motherName' },
            { data: 'nationality' }
        ]
    });
}
