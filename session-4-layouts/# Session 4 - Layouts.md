# Session 4 - Layouts:

## NOTES:
- new folder (models)
- give it a class (called person)
    - properties (id, last name, first name, dob, full name)
    ```csharp
    public string FullName {get => $"{FirstName}, {LastName}";}
    ```
- generate constructor 


- Add folder (services)
- class called (API Datasource)
-  mock list of people
    ``` csharp 
    list <Person> people = [
        new Person("1", "Bob", "Ross", new DateOnly(1942, 10, 29))
    ];

    public List<person> GetPeople(){
        return new List<Person>(people)
    }
    ```

- Main page need to put "using models and services"
- Vertical Stack with a horizontal stack for two buttons at the top
- Then a listview
- APIDatasource _apiDataSource = new();
- One button will show the _apiDataSource.GetPeople(); in the listview
- Data Template 
    - ListView.ItemTemplate > DataTemplate > TextCell Text="{Binding FullName}" Detail="{Binding DateOfBirth}"