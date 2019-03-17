# KeepYourWord
CMS application with a Microsoft Word backend.

For a semi up-to-date demonstration, please visit: https://youtu.be/QAs7UNh8Asg

This project is being completed as part of SWEN 5236 at University of Houston Clear Lake during Spring 2019 semester.
The project requires the completion of up to five features.  The features I've documented are as follows:
* ~~Ability to render web content from MS Word document~~
* ~~Ability to create a website structure from folder paths~~
* ~~Feature where writers/contributors can submit articles for approval~~
* ~~Approval and rejection feature for blog editors or website owners~~
* Customization of blog/website styles (Won't Do)

## Final Update
KYW Has been turned in and no code will be changed until 3/25 when the class officially ends.

## Updates I want to make in the future
If I were to be totally proud of this application, there are a few things I would have to add first.

Being able to control access to the blog "categories" via Windows built in security protocols.  In other words, 
if I'm part of a group that does not have read access to a folder, I will not be able to see that folder in the website.
This would be pretty cool and would really capture the "intra-office" blog I was aiming for.

Also, as you can see above, I skipped the cusomization feature because I couldn't think of a good strategy for handling this, 
and the due date was coming fast.  I would like to add this feature, however it should be noted that directly editing
the CSS should not change the functionality of the application unless you change class and ID names without updating
the JavaScript files.

Linkable pages. Because I lacked foresight, I made this application render pages onto a static page strictly from
AJAX calls.  Therefore, you could never link to or bookmark a specific article.  This was an oversight on my
part and maybe even a little embarassing.

Better SRP adherence.  Right now, many of the classes have HTML attributes that are then returned by controllers so the
web page can populate.  This was really dumb on my part and clearly violates the Single Responsibility Principle. 
In a perfect world, the classes would return only the data relevant about itself, and a controller would turn that 
data into HTML. C'est la vie.

Better name.  I originally called the Solution in VisualStudio "WordStuff" because I was trying to see if what I envisioned
could even be done.  I kept going with it though and in about a day, a significant chunk of "KeepYourWord" was actually
part of "WordStuff."  I changed the names where I could but at this point I'm too scared to change everything else
as I'm afraid it will break the functionality.
