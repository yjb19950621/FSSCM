$(function () {

    var l = abp.localization.getResource('FSSCM');

    var service = fSSCM.customers.customerType;
    var createModal = new abp.ModalManager(abp.appPath + 'Customers/CustomerType/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Customers/CustomerType/EditModal');

    var dataTable = $('#CustomerTypeTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('FSSCM.CustomerType.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('FSSCM.CustomerType.Delete'),
                                confirmMessage: function (data) {
                                    return l('CustomerTypeDeletionConfirmationMessage', data.record.id);
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
                title: l('CustomerTypeIsDefault'),
                data: "isDefault"
            },
            {
                title: l('CustomerTypeName'),
                data: "name"
            },
            {
                title: l('CustomerTypeDiscountrate'),
                data: "discountrate"
            },
            {
                title: l('CustomerTypeAllProductType'),
                data: "allProductType"
            },
            {
                title: l('CustomerTypeAllProductBrand'),
                data: "allProductBrand"
            },
            {
                title: l('CustomerTypeProductBrandIds'),
                data: "productBrandIds"
            },
            {
                title: l('CustomerTypeProductTypeIds'),
                data: "productTypeIds"
            },
            {
                title: l('CustomerTypeSortNum'),
                data: "sortNum"
            },
            {
                title: l('CustomerTypeTenantId'),
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

    $('#NewCustomerTypeButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
