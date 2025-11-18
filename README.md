# Inventory App

## Overview
WinForms (.NET 8) desktop app for the WGU C968 project. The models live in a reusable class library, the UI in a WinForms project, and they follow an MVC-style split. Data is kept in memory via the static `Inventory` store—there is no database backend.

## Projects
- `Models`: defines `Part`, `Inhouse`, `Outsourced`, `Product`, and shared inventory helpers.
- `UserInterface`: WinForms screens (`MainForm`, add/modify dialogs) that bind to the models.

## Key Features
- Data grids for parts and products with search by ID or name.
- Add/modify flows for parts (in-house or outsourced) and products, including associated parts management.
- Validation on numeric fields, inventory bounds, and required inputs before saving.

## Build & Run
1. Open `InventoryApp.sln` in Visual Studio (set `UserInterface` as startup) or run `dotnet restore`.
2. Build: Visual Studio `Build ▸ Build Solution` or `dotnet build`.
3. Run: Visual Studio `F5` or `dotnet run --project UserInterface/InventoryApp.UserInterface.csproj`.

## Usage
- Select rows then `Add`, `Modify`, or `Delete` as needed.
- In product dialogs, use the upper grid to add associated parts and the lower grid to remove them.
- Searches accept numeric IDs or partial names; clear the box to reset results.