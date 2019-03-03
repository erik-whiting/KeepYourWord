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
    console.log("Approval Process Complete");
    location.reload(true);
}

var reject = function () {
    console.log("Starting Rejection Process");
    var fileName = document.getElementById("filename").innerText;
    var approveParam = "approve=false";
    var fileFromParam = "fileFrom=" + fileName;
    var params = approveParam + "&" + fileFromParam;
    var fullUrl = initialUrl + params;
    $.post(fullUrl, function (data, status) {
        console.log(data + " " + status);
    });
    console.log("Rejection Process Complete");
    location.reload(true);
}