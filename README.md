# MyPatrolLogbook
Created by Bright Solutions for Scouts South Africa

Welcome to the MyPatrolLogbook Website  

An MVC ASP.NET CORE web application that will allow Scouts to have access to their patrol logbooks at any time and allow them to keep track of their current Star Patrol Award status is so that they can improve on it before their official Star Patrol Evaluation that occurs at the end of each year.  

********************************************************************************************

#ApplicationName 

MyPatrolLogbook

********************************************************************************************

#Version 

V1.0 

********************************************************************************************

#Contents of this README file: 

Description and How the application works
App installation, start-up instructions 
Build requirements 
Plugins and Imports
Built with
Functional Requirements
Non-Functional Requirements
Troubleshooting
FAQ
Contributions
Authors and Details
Last edited
License
Code Attribution 

********************************************************************************************

#Description and How the application works

MyPatrolLogbook is an MVC ASP.NET Core Web App created in Visual Studio 2022 Community using HTML, CSS, JS, CSHTML and C#, that caters to six different types of users. The first user role is the SuperUser. The SuperUser is the admin account and only one user will have access to it. SuperUser’s have the power to add and override user roles. The second user role is the Provincial Admin. Provincial Admins are in charge of saving Troops within their province to the database and verifying the accounts of New Troop Scouters. They can also view all Troop Scouters within their region and remove any inactive ones. The third role is the Troop Scouter role, and similar to Provincial Admins, they are in charge of saving Patrols within their troops to the database and verifying the accounts of New Scouts. They can also view all Scouts within their troop, edit the scouts patrol and lastly remove any inactive scouts. Troop Scouters can also view the Patrol Logbooks of their troop by filtering by patrol, to view the information saved by the selected patrol. This is similar to what the scouts can see, as it is a read-only. The fourth role is the Patrol Leader role, and this role is assigned to one scout within each patrol. The Patrol Leaders are in charge of updating the patrol logbook and they are the only ones who can create and edit information. The fifth role is the Scout role and this belongs to a regular scout who is not a Patrol Leader. Scouts can only read the information related to their specific patrol. Lastly, the General User role is the role that any unauthenticated used has been assigned. They can only view the Home Page, Privacy Policy Page, How To Guide and Our Team Page. The data are persisted in an Azure SQL Database. Entity Framework Core has been used to access the database.

********************************************************************************************

#App installation and start-up instructions 

Step 1: Open your web browser.  
Step 2: Paste the following URL in the Address Bar: https://mypatrollogbook.azurewebsites.net/     
Step 3: Press ‘Enter’ on your keyboard and the web application should therefore run.   

********************************************************************************************

#Build requirements

– Hardware requirement 

Any device that can connect to the internet.

********************************************************************************************

#Plugins and Imports

- Microsoft.AspNetCore.Identity.EntityFrameworkCore (5.0.17)   			      - Microsoft.EntityFrameworkCore (5.0.17)   		 				      - Microsoft.AspNetCore.Identity.UI (5.0.17)  						     - Microsoft.EntityFrameworkCore.SqlServer (5.0.17)  					     - Microsoft.EntityFrameworkCore.Tools (5.0.17) 					     - Microsoft.Extensions.Identity.Core (5.0.17)      					     - Microsoft.VisualStudio.Web.CodeGeneration.Design (5.0.2)  

********************************************************************************************

#Built with
Visual Studio 2022 Community 

********************************************************************************************

#Functional Requirements

- User can view entries.
- Users can create and edit entries.
- Connected to an Azure SQL Server and data is stored in an Azure SQL Database.

********************************************************************************************

#Non-Functional Requirements
- Usability
- Performance
- Maintainability 
- Scalability
- Reliability

********************************************************************************************

#Troubleshooting 

This web application has been thoroughly tested to ensure that there are no possible errors or bugs during the user experience. It is recommended that the system on which the user is running this application has all the correct software requirements together with the correct project files, plugins and stable internet connection. 

If a problem persists, try rebooting your system and running the application thereafter. If any errors or bugs unexpectedly occur after following all the necessary steps in this file, feel free to drop me an email at brightsolutionsza@gmail.com to assist and improve your user experience. 

********************************************************************************************

#FAQ 

Q. Can I use this application on my MacBook?  
A. Yes you can! This Web Application can be run on both Windows and MacBook devices, as long as you have an internet connection.   

Q. Can I use this application on my cellphone?  
A. Yes you can! This Web Application can be run on most smartphones and tablets, as long as you have an internet connection.   

Q. I’m still waiting for my Troop Scouter/ Provincial Admin to confirm my account. How long does it take?
A. The actual process doesn’t take long at all, however, they may have not seen that they need to verify your account. Maybe just contact them and request for them to verify your account.

Q. I’m a Troop Scouter, why can’t I select the Troop Scouter role?
A. Please ensure that you are registering with your Scouts South Africa email.
********************************************************************************************
#Contributions

Contributions are welcome. They can be sent via email to: 
ST10084382@vcconnect.edu.za  

********************************************************************************************

#Authors and Details 

Name: K Moonasar 

Student Number: ST10084382 

GitHub username: @BrightSolutionsZA 

********************************************************************************************

#Last Edited 

04 December 2023 

********************************************************************************************

#License 

MIT License 

********************************************************************************************

#Code Attribution 

Anderson, R. (2023) Account confirmation and password recovery in ASP.NET Core, Microsoft Learn. Available at: https://learn.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-7.0&amp;tabs=visual-studio (Accessed: 04 December 2023).

ArtSkvira (2014) Using simple Drop Down Lists in ASP.NET MVC, Nimblegecko. Available at: https://nimblegecko.com/using-simple-drop-down-lists-in-ASP-NET-MVC/ (Accessed: 04 December 2023).

ASP.NET MVC DropdownList Use Bind with Database table and Normal Select list (2016). 21 May. Available at: https://www.youtube.com/watch?v=lx72JkMVGqk (Accessed: 04 December 2023).

Bootswatch (no date) Flatly, Bootswatch. Available at: https://bootswatch.com/flatly/ (Accessed: 04 December 2023).

C# Tutorial (2023) C# datetime Parseexact, C# Tutorial. Available at: https://www.csharptutorial.net/csharp-tutorial/csharp-datetime-parseexact/ (Accessed: 04 December 2023).
CodeProject (2011) How to make background image fit to the display in ASP.NET, CodeProject. Available at: https://www.codeproject.com/Questions/188410/How-to-make-background-image-fit-to-the-display-in (Accessed: 04 December 2023).

Color-Hex (no date) Color hex, Color Hex Codes. Available at: https://www.color-hex.com/color/cbbeb5 (Accessed: 04 December 2023).

Export to Excel - ASP.NET Core (2023). 25 April. Available at: https://www.youtube.com/watch?v=o5wFWdujaGM (Accessed: 04 December 2023).
George, S. (2019) Slide-in from right, open from center and Dropdown from top animation for HTML table, CodeMyUI. Available at: https://codemyui.com/slide-in-from-right-open-from-center-and-dropdown-from-top-animation-for-html-table/ (Accessed: 04 December 2023). 

Ferreira, A. (2020) 30+ CSS input text, FreeFrontend. Available at: https://freefrontend.com/css-input-text/ (Accessed: 04 December 2023).

JsonFormatter (no date) Best SCSS to CSS Converter Online, JSON Formatter. Available at: https://jsonformatter.org/scss-to-css (Accessed: 04 December 2023).

Lahav, A. (2022) How to change ASP.NET core web app navbar background color, Stack Overflow. Available at: https://stackoverflow.com/questions/61863477/how-to-change-asp-net-core-web-app-navbar-background-color (Accessed: 04 December 2023).

Learn ASP.NET Core MVC (.NET 6) - Full Course (2021). YouTube. 22 November. Available at: https://www.youtube.com/watch?v=hZ1DASYd9rk (Accessed: 04 December 2023).

Ludwig, D. (2012) Nullable property to entity field, entity framework through Code First, Stack Overflow. Available at: https://stackoverflow.com/questions/10710393/nullable-property-to-entity-field-entity-framework-through-code-first (Accessed: 04 December 2023).

Neff, S. (2010) String was not recognized as a valid datetime ‘ format DD/mm/YYYY’, Stack Overflow. Available at: https://stackoverflow.com/questions/2193012/string-was-not-recognized-as-a-valid-datetime-format-dd-mm-yyyy (Accessed: 04 December 2023).

Silva, A.R. (2021) There is no ViewData item of type ‘IEnumerable’ that has the key country, StackOverflow. Available at: https://stackoverflow.com/questions/26585495/there-is-no-viewdata-item-of-type-ienumerableselectlistitem-that-has-the-key (Accessed: 04 December 2023).

Text Over Image On Mouse Hover In HTML CSS (2023). 23 March. Available at: https://www.youtube.com/watch?v=onH0wKYIU2o (Accessed: 04 December 2023).

W3Schools (no date) How to - toggle password visibility, How To Toggle Password Visibility. Available at: https://www.w3schools.com/howto/howto_js_toggle_password.asp (Accessed: 04 December 2023).

Yogihosting (2023) How to work with roles in ASP.NET Core Identity, YogiHosting. Available at: https://www.yogihosting.com/aspnet-core-identity-roles/ (Accessed: 04 December 2023).

Image References:

Adiga, A.K. (no date) I’m Arvind., GitHub. Available at: https://messiadiga.github.io/CSS_cv/ (Accessed: 30 November 2023). 

Cheremisinova, I. (2020) Couple trekking on mountain., iStock. Available at: https://www.istockphoto.com/vector/couple-trekking-on-mountain-man-and-woman-traveling-in-mountains-standing-on-top-gm1281268523-379350898 (Accessed: 29 November 2023). 

ClipartLibrary (no date) Transparent Camping Cliparts, Clipart Library. Available at: https://clipart-library.com/clipart/749014.htm (Accessed: 29 November 2023). 

Clipground (no date) Community clean up clipart, Clipground. Available at: https://clipground.com/pics/get (Accessed: 29 November 2023). 
Hale, I. (no date) 1st Cheddington Scout Group, Factsheets. Available at: http://www.cheddingtonscouts.org.uk/index.php/sections/explorers/resources/182-scout-skills-factsheets15 (Accessed: 02 December 2023). 

Illust AC (no date) Boy scout men and women set, Free Vectors, Clipart &amp; Stock Illustrations for Download - illustAC. Available at: https://en.ac-illust.com/ (Accessed: 30 November 2023). 

JeDécore (no date) GIF camping 7, JeDécore. Available at: https://www.jedecore.com/img/gif/camping/camping-7/ (Accessed: 30 November 2023). 

Kkkiiiaaa (2022) Check lists purple GIF, Tenor. Available at: https://tenor.com/en-GB/view/check-lists-purple-list-gif-26728867 (Accessed: 30 November 2023). 

Lisitsaimage (2017) Smiling disabled girl in wheelchair and her school friends sitting around round table, reading books and talk to each stock vector - illustration of disabled, group: 104905540, Dreamstime. Available at: https://www.dreamstime.com/smiling-disabled-girl-wheelchair-her-school-friends-sitting-around-round-table-reading-books-talk-to-each-other-concept-image104905540 (Accessed: 02 December 2023). 

Nesterenko, N. (no date) Couple in bowling alley , iStock. Available at: https://www.istockphoto.com/vector/couple-in-bowling-alley-2d-vector-web-banner-poster-gm1266587271-371335866 (Accessed: 29 November 2023). 

Pictotraductor (no date) Scout, Pictotraductor. Available at: https://www.pictotraductor.com/frase/397509/mirador-implante-coclear-marcapasos-subtitulo-noreste-suroeste-noroeste-sureste-jilguero-granero-tarjeta-de-transporte-regular-remar-monitorizar-gotero-preoperatorio-respiracion-asistida-pinchazo-scout-uvi-movil- (Accessed: 30 November 2023).

Ratta, A. (no date) What are some ways to make people recycle more often?, Quora. Available at: https://www.quora.com/What-are-some-ways-to-make-people-recycle-more-often (Accessed: 29 November 2023). 

Scouts South Africa (2014) Cederberg coverimage, Scouts South Africa. Available at: https://www.scouts.org.za/cederberg-coverimage/ (Accessed: 04 December 2023).

Scouts South Africa (2017) scouts-logo-badge-layers, SCOUTS South Africa. Available at: https://www.scouts.org.za/2017/04/03/join-ssa-billboard-campaign-gauteng/scouts-logo-badge-layers/ (Accessed: 29 November 2023). 

Scouts South Africa (no date) Gold Star - Star Awards, SCOUTS South Africa. Available at: https://www.scouts.org.za/members/gold-star-star-awards/ (Accessed: 29 November 2023). 

Scouts South Africa (no date) Springbok Award, SCOUTS South Africa. Available at: https://www.scouts.org.za/members/scouts/springbok-award/ (Accessed: 29 November 2023). 
Shutterstock (no date a) Friends sit by campfire flat vector stock vector (royalty free) 1435601684, Shutterstock. Available at: https://www.shutterstock.com/image-vector/friends-sit-by-campfire-flat-vector-1435601684 (Accessed: 02 December 2023). 

Shutterstock (no date b) Summer Camp Scouts together cool vector stock vector (royalty free) 1379911412, Shutterstock. Available at: https://www.shutterstock.com/image-vector/summer-camp-scouts-together-cool-vector-1379911412 (Accessed: 02 December 2023). 

Shutterstock (no date) Friendship Break Dinner Business Pizza Junk Stock Vector (royalty free) 1773331289, Shutterstock. Available at: https://www.shutterstock.com/image-vector/friendship-break-dinner-business-pizza-junk-1773331289 (Accessed: 02 December 2023). 

Signkey (no date) Ascending graph, bar graphs, progress, chart, increase ... - pngwing, Pngwing. Available at: https://www.pngwing.com/en/free-png-vefei (Accessed: 01 December 2023). 

Zuperial (no date) Scouting, FreeP!k. Available at: https://www.freepik.com/premium-vector/scouting-landing-page-design-template-online-summer-club-school-outdoor-training-class-service-website-vector-illustration-with-happy-excited-schoolchildren-teacher-exploring-nature_63393846.htm (Accessed: 29 November 2023). 

********************************************************************************************
![image](https://github.com/BrightSolutionsZA/MyPatrolLogbook/assets/105204001/978520db-dbcc-4e96-a7db-26c298af4b68)
