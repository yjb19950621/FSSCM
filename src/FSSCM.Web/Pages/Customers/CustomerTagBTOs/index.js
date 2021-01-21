$(function () {

    var l = abp.localization.getResource('FSSCM');

    var service = fSSCM.customers.customerTagBTOs;
    var createModal = new abp.ModalManager(abp.appPath + 'Customers/CustomerTagBTOs/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Customers/CustomerTagBTOs/EditModal');

    var dataTable = $('#CustomerTagBTOsTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('FSSCM.CustomerTagBTOs.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('FSSCM.CustomerTagBTOs.Delete'),
                                confirmMessage: function (data) {
                                    return l('CustomerTagBTOsDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('CustomerTagBTOsCustomerId'),
                data: "customerId"
            },
            {
                title: l('CustomerTagBTOsTagId'),
                data: "tagId"
            },
            {
                title: l('CustomerTagBTOsTenantId'),
                data: "tenantId"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewCustomerTagBTOsButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
