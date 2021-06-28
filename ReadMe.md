# ASP.NET Identity

In this assignment, we will create a Content Management System (a CMS), that will let an authorized user log into the page and edit the data in the database without accessing the code.

## Required Features:
* Any user should be able to register a user account, and once an account has been created, they should be able to:
	* View a list of people
* Should be possible to flag user as admin
	* Admins should be able to do anything normal users can.
	* Admins should be able to edit and delete people.
	* In addition, they should be able to create, edit and delete cities and countries.
* If you are not an admin, the classes cities and countries should not be viewable or editable, but they should be available as options in a dropdown selection element on the account creation page.
* There should be a relationship between the countries and cities classes. The country should be able to have many cities.

## Code Requirements:
* Use ASP.NET Identity to manage roles and accounts.
* Authorization should be done through roles, which are assigned to users.

## Resources:
https://app.pluralsight.com/library/courses/authentication-authorization-aspnet-core/table-of-contents
https://www.yogihosting.com/aspnet-core-identity-authentication https://www.yogihosting.com/aspnet-core-identity-roles/ https://www.yogihosting.com/aspnet-core-identity-custom-user-properties/

## Subjects Covered:
* Authentication through ASP.NET Identity
* Content Management Systems