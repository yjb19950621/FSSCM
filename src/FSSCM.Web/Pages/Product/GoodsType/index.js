$(function () {

    var l = abp.localization.getResource('FSSCM');

    var service = fSSCM.product.goodsType;
    var createModal = new abp.ModalManager(abp.appPath + 'Product/GoodsType/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Product/GoodsType/EditModal');

    var dataTable = $('#GoodsTypeTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('FSSCM.GoodsType.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('FSSCM.GoodsType.Delete'),
                                confirmMessage: function (data) {
                                    return l('GoodsTypeDeletionConfirmationMessage', data.record.id);
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
                title: l('GoodsTypeTypeCode'),
                data: "typeCode"
            },
            {
                title: l('GoodsTypeTypeName'),
                data: "typeName"
            },
            {
                title: l('GoodsTypeIsDefault'),
                data: "isDefault"
            },
            {
                title: l('GoodsTypeLeafTypeFlag'),
                data: "leafTypeFlag"
            },
            {
                title: l('GoodsTypeMainImg'),
                data: "mainImg"
            },
            {
                title: l('GoodsTypeMainImgUrl'),
                data: "mainImgUrl"
            },
            {
                title: l('GoodsTypeImgUrl'),
                data: "imgUrl"
            },
            {
                title: l('GoodsTypeParentTypeId'),
                data: "parentTypeId"
            },
            {
                title: l('GoodsTypeShowPageType'),
                data: "showPageType"
            },
            {
                title: l('GoodsTypeOrder'),
                data: "order"
            },
            {
                title: l('GoodsTypeTypeLevel'),
                data: "typeLevel"
            },
            {
                title: l('GoodsTypeTenantId'),
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

    $('#NewGoodsTypeButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
