function navigate(target) {
    //Perform your AJAX call to your Controller Action
    $.post(target,{ UserName: $('#UserName').val(), Password: $('#Password').val() });
}
