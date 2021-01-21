$(function () {

    var l = abp.localization.getResource('FSSCM');

    var service = fSSCM.product.goodsUnit;
    var createModal = new abp.ModalManager(abp.appPath + 'Product/GoodsUnit/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Product/GoodsUnit/EditModal');

    var dataTable = $('#GoodsUnitTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('FSSCM.GoodsUnit.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('FSSCM.GoodsUnit.Delete'),
                                confirmMessage: function (data) {
                                    return l('GoodsUnitDeletionConfirmationMessage', data.record.id);
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
                title: l('GoodsUnitGoodsUnitName'),
                data: "goodsUnitName"
            },
            {
                title: l('GoodsUnitStatus'),
                data: "status"
            },
            {
                title: l('GoodsUnitTenantId'),
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

    $('#NewGoodsUnitButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
