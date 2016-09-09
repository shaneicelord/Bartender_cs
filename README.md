# Bartender_cs
Bartender application using MVC c#.net

My Feedback
.gitignore - don't need the bin folder included - should use the standard VS .gitignore
Database - connectionstring should go into a settings file like the appsettings in webconfig
Use implicit variable declaration:
Instead of 
SqlDataReader reader = cmd.ExecuteReader();
var reader = cmd.ExecuteReader();
