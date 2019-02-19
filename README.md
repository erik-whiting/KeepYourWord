# KeepYourWord
CMS application with a Microsoft Word backend

This project is being completed as part of SWEN 5236 at University of Houston Clear Lake during Spring 2019 semester.
The project requires the completion of up to five features.  The features I've documented are as follows:
* ~~Ability to render web content from MS Word document~~
* ~~Ability to create a website structure from folder paths~~
* Feature where writers/contributors can submit articles for approval
* Approval and rejection feature for blog editors or website owners
* Customization of blog/website styles

## 2/4/2019 status
Project will parse Word file into HTML.  Change the path in WordDocsController to your local path in which Word 
to be parsed reside.  You must hit the worddocs API endpoint with the name of the file you want parsed, like so:
http://localhost:20777/api/worddocs?filename=samplepost

### Still Working on:
Parsing bold/italic text
Supporting nested lists

## Next update
Will be calling this API via AJAX to render onto an actual webpage when clicking a link.
