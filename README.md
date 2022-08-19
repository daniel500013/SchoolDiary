# School Diary API
School Diary API project created for educational purposes.

# Requirements
`` SQL Server >2016``
<br />
``.NET Core 6``
<br />
``Angular >14``

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

# Problems (To Do)
- ``Teacher may insert a grade in a subject he dosen't teach``
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