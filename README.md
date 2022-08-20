# School Diary API
School Diary API project created for educational purposes.

# Requirements
`` SQL Server >2016``
<br />
``.NET Core 6``
<br />
``Angular >14``

# Documentation
[Link to documentation here](https://daniel500013.github.io/SchoolDiary/Swagger/)

# Graphic diagram of database
![](/git/baza.png)

# Features
- ``Lesson management``
- ``Assessment management``
- ``Presence management``
- ``Approve management``
- ``Classroom management``
- ``Role management``
- ``Managing assignment parents to students``
<br />

# Default login
### Admin
`` Login: admin@admin.com``
<br />
`` Password: admin``
<br />

# Database
### Configuration
To ensure that error dosen't occur when connecting to database, data needed for connection should be substituted in the file ``appsettings.json`` by line ``9``
### Adding 
To add database from migration, use update-database command in package manager
#### Example
> PM> update-database
