(function (Home, $, undefined) {
    'use strict';

    Home.init = function () {
        var options = {
            clearForm: false,
            data: {},
            success: function (jsonData) {
                if (jQuery.isEmptyObject(jsonData)) {
                    alert("Cannot read data!");
                    return false;
                }
                if (!jsonData.result) {
                    alert(sonData.message);
                    return false;
                }

                alert('Name: ' + jsonData.data.name);
                alert('Deposit: ' + jsonData.data.deposit);
            },
            error: function (xhr, status, error) {
                var errorMessage = (error.message) ? error.message : error;
                alert(errorMessage);
            }
        };
        $('#formEdit').ajaxForm(options);
    };

    Home.render = function () {

    };

}(window.Home = window.Home || {}, jQuery));