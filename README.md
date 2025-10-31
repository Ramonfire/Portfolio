Portfolio

A portfolio website built using C# and .NET.
This project is working locally, but not yet deployed to a public URL.

Table of Contents

Overview

Features

Tech Stack

Getting Started

Usage

Project Structure

Future Improvements

Contributing

License

Overview

This repository contains a portfolio website built with C# and the .NET framework (or .NET Core/ASP.NET — adjust accordingly).
It’s intended to showcase personal/projects work in a clean, responsive way.
Although it’s fully functional when run locally, it hasn't yet been deployed to a live server.

Features

Home / About section — introduction and background.

Projects section — list of completed/ongoing work.

Contact section — form or contact details to reach out.

Responsive design — works across desktop and mobile.

Clean modern UI using HTML, CSS (and possibly JavaScript) plus back-end C# logic.

Easy to expand/add new projects or pages.

Tech Stack

C#

.NET (or ASP.NET Core)

HTML5 & CSS3

JavaScript (for any UI enhancements)

(Optional) Any CSS framework (e.g., Bootstrap) or custom styling

(Optional) Use of MVC architecture or Razor Pages (adjust if applicable)

Getting Started
Prerequisites

.NET SDK
 installed on your machine.

A code editor (e.g., Visual Studio, Visual Studio Code).

(Optional) Node/npm if you have front-end build tools.

Installation

Clone the repository:

git clone https://github.com/Ramonfire/Portfolio.git  
cd Portfolio  


Restore dependencies and build the solution:

dotnet restore  
dotnet ef databse update (insert your own data in the db)
dotnet build  


Run the application:

dotnet run  


Open a browser and navigate to http://localhost:5000 (or the URL shown in your console) to view the site.
the app only has Get Methods as to prevent data modification
