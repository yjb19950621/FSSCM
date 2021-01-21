$(function () {

    var l = abp.localization.getResource('FSSCM');

    var service = fSSCM.customer.customer;
    var createModal = new abp.ModalManager(abp.appPath + 'Customer/Customer/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Customer/Customer/EditModal');

    var dataTable = $('#CustomerTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('FSSCM.Customer.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('FSSCM.Customer.Delete'),
                                confirmMessage: function (data) {
                                    return l('CustomerDeletionConfirmationMessage', data.record.id);
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
                title: l('CustomerUserName'),
                data: "userName"
            },
            {
                title: l('CustomerName'),
                data: "name"
            },
            {
                title: l('CustomerCustomerStatus'),
                data: "customerStatus"
            },
            {
                title: l('CustomerCode'),
                data: "code"
            },
            {
                title: l('CustomerCustomRegionId'),
                data: "customRegionId"
            },
            {
                title: l('CustomerCompanyUserId'),
                data: "companyUserId"
            },
            {
                title: l('CustomerLogisticsCode'),
                data: "logisticsCode"
            },
            {
                title: l('CustomerCustomerTypeId'),
                data: "customerTypeId"
            },
            {
                title: l('CustomerWarehouseId'),
                data: "warehouseId"
            },
            {
                title: l('CustomerZipCode'),
                data: "zipCode"
            },
            {
                title: l('CustomerSuperiorStatus'),
                data: "superiorStatus"
            },
            {
                title: l('CustomerExtra'),
                data: "extra"
            },
            {
                title: l('Customerfax'),
                data: "fax"
            },
            {
                title: l('CustomerAddress'),
                data: "address"
            },
            {
                title: l('CustomerActiveCustomer'),
                data: "activeCustomer"
            },
            {
                title: l('CustomerSuperiorEmployeeId'),
                data: "superiorEmployeeId"
            },
            {
                title: l('CustomerSuperiorCustomerId'),
                data: "superiorCustomerId"
            },
            {
                title: l('CustomerSettlement'),
                data: "settlement"
            },
            {
                title: l('CustomerContactor'),
                data: "contactor"
            },
            {
                title: l('CustomerPosition'),
                data: "position"
            },
            {
                title: l('CustomerMobile'),
                data: "mobile"
            },
            {
                title: l('CustomerPhone'),
                data: "phone"
            },
            {
                title: l('CustomerEmail'),
                data: "email"
            },
            {
                title: l('CustomerQQ'),
                data: "qQ"
            },
            {
                title: l('CustomerInvoice'),
                data: "invoice"
            },
            {
                title: l('CustomerTaxNum'),
                data: "taxNum"
            },
            {
                title: l('CustomerInvoiceAddress'),
                data: "invoiceAddress"
            },
            {
                title: l('CustomerInvoiceMobile'),
                data: "invoiceMobile"
            },
            {
                title: l('CustomerBankName'),
                data: "bankName"
            },
            {
                title: l('CustomerBank'),
                data: "bank"
            },
            {
                title: l('CustomerBankAccount'),
                data: "bankAccount"
            },
            {
                title: l('CustomerDebtTypeId'),
                data: "debtTypeId"
            },
            {
                title: l('CustomerIsDebtInit'),
                data: "isDebtInit"
            },
            {
                title: l('CustomerLastReconciliationTime'),
                data: "lastReconciliationTime"
            },
            {
                title: l('CustomerLongitude'),
                data: "longitude"
            },
            {
                title: l('CustomerLatitude'),
                data: "latitude"
            },
            {
                title: l('CustomerBeginSign'),
                data: "beginSign"
            },
            {
                title: l('CustomerEndSign'),
                data: "endSign"
            },
            {
                title: l('CustomerCountryId'),
                data: "countryId"
            },
            {
                title: l('CustomerProvinceId'),
                data: "provinceId"
            },
            {
                title: l('CustomerCityId'),
                data: "cityId"
            },
            {
                title: l('CustomerDistrictId'),
                data: "districtId"
            },
            {
                title: l('CustomerTagIds'),
                data: "tagIds"
            },
            {
                title: l('CustomerTenantId'),
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

    $('#NewCustomerButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
