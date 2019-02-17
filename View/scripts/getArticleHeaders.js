var getHeaders = function (direcotry) {
    var htmlContent = '';
    var contentDiv = $('#content-div');
    contentDiv.html('');
    console.log('Beginning GetHeaderList');
    $.ajax({
        url: 'http://localhost:20000/api/headerlist/GetHeaderList/?directoryName=' + direcotry,
        success: function (data) {
            htmlContent += data;
            contentDiv.html(htmlContent);
            console.log('GetHeaderList completed');
        },
        error: function (error) {
            htmlContent = '<p>' + error + '</p>';
            console.log('GetHeaderList failed');
        }
    });
}

var addLinkToArticle = function (docName) {
    var openTag = '<a href="#" onClick="loadDoc(\'' + docName + '\')">';
    var closeTag = '</a>';
}