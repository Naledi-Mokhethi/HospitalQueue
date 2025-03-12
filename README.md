# Hospital Emergency Room Priority Queue

### Overview
This is a basic hospital emergency room management system. 
It is designed to queue walk in patients based on the urgency of their medical emergency.

### Detailed Walkthrough 
- The project is follows the MVC Structure.
- It is built on .NET 8.
- It is a C# website.
- The project DAL uses SQL Express and was developed using SSMS
- The frontend is built using HTML, CSS and JavaScript.
- On form submission there is a beautiful confirm dialog implemented with SweetAlert
- It has Data Transfer Objects 

### Developers Guide 
- Application was developed using visual studio however, vs-code can be used.
- You need to have an SQL/SQLExpress database installed.
- Install the .NET 8 SDK.
- I prefer SSMS for database modifications but Visual Studio also has some amazing database tools available.

### Purpose
- The primary objective of this project is to work with data structures.
- The project includes a custom node class and a custom priority queue class.
- The Form takes the user input and temporarily store's the data in the node as a list.
- The patients are queued according to the severity of their problems.
- Once a patient has been helped the dequeue is triggered. 
- The patient data is written to the database using dapper for record keeping purposes. 

### Pending Updates 
- Login for Nurse's to limit access to functionalities such as the dequeue.
- Login will use a RESTful Authentication API. 
- A get patients records that will read and export the history of the ER Patients for audit purposes.

### Credit
- The UI Template was acquired on themewagon.com
- Please follow this URL to see or download the full template:
https://themewagon.com/themes/free-responsive-html5-bootstrap-medical-website-template-medic/
A special thanks to the front-end developer/team that created this beautiful template
- Note, Theme was customized to meet my requirements so if you need the full one. Please follow the link.
