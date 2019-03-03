var initialUrl = "http://localhost:20000/api/approve/ApproveOrReject/?";

var approve = function () {

    console.log("Starting Approval Process");
    var destinationBox = document.getElementById("destination");
    var fileName = document.getElementById("filename").innerText;
    var destination = destinationBox.value;
    var approveParam = "approve=true";
    var fileFromParam = "fileFrom=" + fileName;
    var fileToParam = "fileTo=" + destination + "\\";
    var params = approveParam + "&" + fileFromParam + "&" + fileToParam;
    var fullUrl = initialUrl + params;
    $.post(fullUrl, function (data, status) {
        console.log(data + " " + status);
    });
    localtion.reload(true);
    console.log("Approval Process Complete");
}

var reject = function () {
    console.log("Starting Rejection Process");
    console.log("Rejection Process Complete");
}