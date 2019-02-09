var htmlContent = '';
var contentDiv = $('#content-div');
console.log('Beginning GetWordDocHtml');
$.ajax({
    url: 'http://localhost:20000/api/worddocs/GetWordDocHtml/?filename=samplepost',
    success: function (data) {
        htmlContent = data;
        contentDiv.html(htmlContent);
        console.log('GetWordDocHtml Success');
    },
    error: function (error) {
        htmlContent = '<p>' + error + '</p>';
        console.log('GetWordDocHtml Fail');
    }
})