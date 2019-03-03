const url = 'http://localhost:20000/api/handlefileupload/Post';

var uploadFile = function () {
    const form = document.querySelector('form');
    form.addEventListener('submit', e => {
        const files = document.querySelector('[type=file]').files;
        const formData = new formData();

        for (let i = 0; i < files.length; i++) {
            let file = files[i];
            formData.append('files[]', file);
        }

        fetch(url, {
            method: 'POST',
            body: formData
        }).then(response => {
            console.log(response);
        });
    });
}
