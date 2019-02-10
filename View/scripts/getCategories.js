var htmlContent = '';
var menuDiv = $('#menu-div');
console.log('Beginning GetDirectoryStructure');
$.ajax({
    url: 'http://localhost:20000/api/directorystructure/GetDirectoryStructure/',
    success: function (data) {
        var directories = data.directoryStructureDtos;
        directories.forEach(function (directory) {
            htmlContent += '<a href="#">' + directory.FolderName + '</a>';
            subDirectories = directory.SubDirectoryDtos;
            subDirectories.forEach(function (subDirectory) {
                htmlContent += '<a class="nav-sub-dir" href="#">' + subDirectory.FolderName + '</a>';
            });
        });
        menuDiv.html(htmlContent);
        console.log('GetDirectoryStructure Success');
    },
    error: function (error) {
        htmlContent = '<p>' + error + '</p>';
        console.log('GetDirectory Structure Failed');
    }
});