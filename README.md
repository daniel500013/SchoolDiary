# School Diary API
School Diary API project created for educational purposes.

# Requirements
`` SQL Server >2016``
<br />
``.NET Core 6``
<br />
``Angular >14``

# Documentation
If you wanna check documentation without cloning repository check link below
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
Use migrations.sh file in tool folder for migration
#### Example
> ./migration.sh
