var htmlContent = '';
var menuDiv = $('#menu-div');
console.log('Beginning GetDirectoryStructure');
$.ajax({
    url: 'http://localhost:20000/api/directorystructure/GetDirectoryStructure/',
    success: function (data) {
        var directories = data.directoryStructureDtos;
        directories.forEach(function (directory) {
            jsClickEvent = ' onClick="getHeaders(\'' + directory.FolderName + '\')" ';
            htmlContent += '<a href="#"' + jsClickEvent + '>' + directory.FolderName + '</a>';
            
            if (directory.Directories !== undefined || directory.Directories.length != 0) {
                directory.Directories.forEach(function (subDirectory) {
                    jsClickEvent = ' onClick="getHeaders(\'' + subDirectory.FolderName + '\')" ';
                    htmlContent += '<a class="nav-sub-dir" href="#"' + jsClickEvent + '>' + subDirectory.FolderName + '</a>';
                });
            }
            
        });
        menuDiv.html(htmlContent);
        console.log('GetDirectoryStructure Success');
    },
    error: function (error) {
        htmlContent = '<p>' + error + '</p>';
        console.log('GetDirectory Structure Failed');
    }
});