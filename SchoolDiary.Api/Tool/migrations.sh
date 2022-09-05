cd .. || exit

echo "Migration name:"
read -r migrationName

dotnet ef migrations add "$migrationName"
dotnet ef database update "$migrationName"