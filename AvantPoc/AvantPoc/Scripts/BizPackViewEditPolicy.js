$( function() {

    var dialog, form;
    

    dialog = $( "#dialog-form" ).dialog({
        autoOpen: false,
        height: 400,
        width: 350,
        modal: true,
        //buttons: {
        //  "Create an account": addUser,
        //  Cancel: function() {
        //    dialog.dialog( "close" );
        //  }
        //},
        close: function() {
            
        }
    });
   
    $("#allianz-modal").button().on("click", function () {

        var params = '&ProductCode=abc';
        //var GetInsurerUrl = '@Url.Action("Action", "Controller")';

        //debugger;

        $.ajax({
            url: "http://localhost:60000/api/Insurer/GetInsurerURL",
            data: params,
            cache: false,
            type: 'GET',
            contentType: "application/text;charset=utf-8",
            dataType: 'html',
            success: function (result) {

                debugger;
                var x = result;

                dialog.dialog("open");
                return false;

            },
            error: function (errorThrown) {
                debugger;
                var errorMsg = errorThrown;
            }
        });

    });
} );
