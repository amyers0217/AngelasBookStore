// WEB 452 Assignment 2
// Angela Myers 0796187

// 2022-10-21 12:43PM
- Built the inital application --> ASP.NET Core MVC 3.1 (C#)
- Prepended my name: 'AngelasBookStore'
- Individual Account Authentification
- Added Razor runtime...

- Hit create and then reviewed the default app
// 12:46PM

// 2022-10-24 1:10PM
- Cloned the repository from GitHub
- Built the app to make sure things are still working
- Opened the app on the web to make sure it opened
	- Both were successful

- Looking through the assignment 2 slides

// 2022-10-28 12:02PM
- Cloned repositorty from GitHub
- Built the app to make sure things are still working
- Removed initial default in Startup.cs ...                
	options => options.SignIn.RequireConfirmedAccount = true

- Bootswatch Theme is Lux
- Changed bootstrap.min.css to bootstrap.css in View > Shared > _Layout.cshtml
- Changed the nav vlass from navbar-light to navbar-dark
- Changed bg-white to bg-primary
- Removed all of the instances of text-dark from _Layout.cshtml and _LoginPartial.cshtml
- Rebuilt the project and ran it to make sure things are working
	- Once ran, you can see the change of theme

- Added additional script for CSS and JS from the files provided on Blackboard

- Added the dropdown but at the moment it doesn't work... 1:08PM

- Look through the Bootswatch .css that I choose to see what kind of changes could be made

// 2022-10-21 12:06PM
- Cloned repository from GitHub
- Built the app to make sure things are working and ran the app
	- Everything was successful

- Having issue with the dropdown menu... there was code missing in the nav class 
	- This code was added to the <a class> for the dropdown nav bar (id ="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false")

1:02PM
- Adding 3 new projects to the application
	- AngelasBookstore.DataAccess
	- AngelasBookstore.Models
	- AngelasBookstore.Utility

- Installed NuGet Package Microsoft.EntityFrameworkCore.Relational
- Deleted the original Data Folder and the Migrations folder in the AngelasBooks.DataAccess>Data Folder

1:34PM
- Running into errors with Part 1.4

// 2022-11-03 7:44PM
- There are a bunch  of errors after I completed Part 1.4 ... going to try from the beginning again to see if there was something I did wrong

9:54PM
- Went through the rest of the assignment and stopped at Part 1.4 after I added the 3 new projects to the application
	- AngelasBooks.DataAccess
	- AngelasBooks.Models
	- AngelasBooks.Utility

- Is there something missing in the instructions for the assignment or am I just missing something?

// 2022-11-04 10:01AM
- Trying to work through the issues I was having last night
- Was having issues trying to commit to GitHub, started over clean again and got rid of repositories I didn't need
- Atempting Part 1.4 again (10:26AM)
	- This is where I was having issues in lab and at home
	- Once I started moving files and deleting the originals I wasn't sure where to go after this
- Stopping here (10:29AM)

12:15PM
- Cloned the repository in lab
- Built the project and opened in the browser... everything is working curently

// 2022-11-07 11:59PM
- Cloned repository from GitHub
- The class libraries were not found so I had to re-add them to the project
	- I don't think they were pushed to GitHub for some reason

- Added Project References
- Renamed the Models folder in AngelasBooks.Models to ViewModels
	- Also changed the namespace to match
- Errors when building the project
	- Not sure how to fix the errors in Startup.cs
- Created SD.cs in the Utility project and added a project reference
- Added a Customers area to Areas

// 2022-11-14 12:12PM
- Cloned the repositoryf from GitHub
- 2 errors coming up on Startup.cs

- Trying Part 2
- Added Repository folder to AngelasBooks.DataAccess
- Added IRepository folder to Repository folder
- Added IRepository.cs to IRepository folder

3:12PM
- This is attempt #3 of the assignment
- Having a lot of errors and not sure what to do next so decided to start over again

3:46PM
- Starting Part 1.4 (this is where I am having the most issues)
- Added the 3 class libraries
	- No issues currently
- Installed NuGet Packages
- Modified namespace to reflect the project
- Built the project, so far no issues...

4:13PM
- Getting a namespace error with 'ErrorViewModel' saying it could not be found
	-Commented both of these lines out because I was getting an error I couldn't fix
	@*@model ErrorViewModel*@   

	@*@if (Model.ShowRequestId)
		{
			<p>
				<strong>Request ID:</strong> <code>@Model.RequestId</code>
			</p>
		}*@
	- This seems to be working now... Not sure if this will effect the Error page but right now (4:33PM) the app opens in the browser

- What properties are we modifying in the SD class?
- Is the 'Customers' area in Areas a folder?
- Stopping for the day @4:39PM

// 2022-11-17 2:17PM
- Cloned the repository from GitHub
- Continuing from Part 1
	- Slide 37 of 39
	- Not sure what is being asked here... would be helpful if there was more information given
- Trying to add the Customers area but it won't allow me to unless I "fix the errors present"
	- For some reason the AngelasBooks projects were copied over to the AngelasBookStore project... I deleted those files and this may have fixed the issue
- Added the Cusomters area to Areas successfully (after deleting those project files in the main project)
- Is there a specific place to add the code from the ScaffoldingReadMe.txt?
	- /* app.UseMvc(routes =>
        {
          routes.MapRoute(
            name : "areas",
            template : "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
        }); */
	- Not sure where to put this code
- Where are we moving Views > Home to?
- Which Controllers folder are we deleting?

3:31PM
- Starting Part
- Created initial migration and updated the database
	- Migration file name: 20221117210312_InitialCreate.cs
- Added Category.cs to .Models

5:17PM
- I may have added the wrong migration the first time around...
	- 20221118010347_AddDefaultIdentityMigration.cs (This was the migration done by code-first)

8:30PM
- Running into build errors when trying to add the Category to DB migration

// 2022-11-23 2:09PM
- Starting the assignment over... was not able to figure out the build errors
- Still using the bootstrap theme Lux

3:11PM
- Part 1 was successful and I didn't run into any issues like I was in the past

3:33PM
- Migration file name 20221123203248_AddDefaultIdentityMigration.cs
- Updataed the database
- Added AddCategoryToDb migration to .DataAccess
- Updataed the database
- To this point everything is running smoothly

4:51PM
- Added Repository folder to .DataAccess
- Added IRepository folder to Repository folder
	- Added ICategory.cs and IRepository.cs to IRepository folder
	- Added Category.cs and Repository.cs to Repository folder
	- Modified the files so everything works

5:38PM
- Added code to Unit Of Work
- Everything is working as of this time and date!

2022-11-24 1:33PM
- Continuing where I left off last night
- Having an error with services.AddScoped<IUnitOfWork, UnitOfWork>();

- Added Category Controller class to Admins
- Added Upsert and the partial views for the Create and Edit functions

2:52PM
- Still getting an error with IUnitOfWork saying it does not contain a definition for 'Category'
	- Not sure where to go from here
	- Will try and email the professor about this issue...

- Added the ability to delete and made these changes to the category.js file

3:34PM
- Taking a break before moving on to Part 3(Section 1)

4:45PM
- Starting Part 3 (Section 1)
- I went to update the database(not sure if this needs to be done) before going through the steps for Cover Type and the 'Build Failed'
	- Getting the same error when trying to Add-Migration AddCoverTypeToDb
	- I added the interface and class files to Repository and IRepository but did not change anything in the files
	- Going to just move onto the next part because I don't want to start this over again for the 5th time...
- Added Product.cs to .Models and modified the code
- Not able to Add-Migration for Products either... getting Build Failed

6:14PM
- Making sure to have all the folders and files even though I am unable to do some of the tasks...

6:28PM
- Finished with Part 3 of the assignment
- Currently have a lot of errors and I don't know how they should be fixed
- I feel like there should be more instructions throughout the assignment to explain what has to be done

// 2022-11-25 9:48AM
- Looked through the files to make sure all the using statements are correct (based on Andrew's email response), but it looks like everything is correct?
- Will review in lab today

2:55PM
- This is the BackUp project from the main
- Going to be trying to work through some of the errors I was getting before I continue with Part 3 and Part 4
- Deleted everything that was causing an error... I think I have to go back to the part after adding the category to the database
- The database was able to be updated
- I was also able to see the updated database in the SQL Server Object Explorer
- Build is successful up until adding the IUnitOfWork interface

// 2022-11-26 12:58PM
- I could be wrong but it looks like there could have been some things missing from the README and Project between 3:00PM and 5:00PM 2022-11-25
	- I was having issues with GitHub commits
	- I also know I made the Cover Type Controller but it is not in the project today...
	- Will have to continue from that step
	- Everything is working like it should up until this point!

- Added the CoverTypeController again as well as the Index and Upsert to the Views/CoverType folder
- On the Create Cover Type page there is a random } at the bottom... maybe something in the coverType.js file? Will investigate
	- There was an extra } at the end of the @section Scripts in the Upsert.cshtml file

- Added the Product class and the migration to the database
	- Migration name 20221126183445_AddProductToDb.cs
- Added productRepository class and IProductRepository interface and the appropriate code

// 2022-11-27 @2:03PM
- Started working on Assignment 2 where I finished off yesterday
- Finished iup Part 3 Section 2
	- Everything is working up intill this point
- Added the Index.cshtml with appropriate code to the Product folder in Areas/Admin/Views
- There were a few "errors" I noticed when adding the Product Index so I went through and fixed those
	- Fixed some of the code that said Category or Create New Category to reflect Product (this was because we just copied the Index code from Category to the Product Index)
		- Made sure to check the CoverType Index and Upsert as well
- Added the Upsert.cshtml and used tiny.cloud to add a textbox area to the Create New Product page
- The Product page loads correctly and everything is working

- I changed how the Home Index page looks as well
	- Removed the "Learn More" link and added some more info

- I tried to add a new product to the product page but it wouldn't allow me to because of the two required fields
	- Category type and Cover Type
	- I will have to look through the code and compare with the repository that was provided to see what I am missing

3:22PM
- Made some code changes to the HomeController based off of comparing the provided repository to my own code
	- Referencing IUnitOfWork
	- Referencing Product and productList
	- Wondering if this will allow me to create a new product and post it to the database?
	- These changes threw and exception error... I will probably have to change some of the other files for this not to be an issue
- I added to items to Cover Type
	- Hardcover
	- Paperback
	- But they still do not show up in the list when adding a new product...